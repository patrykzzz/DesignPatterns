using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using NUnit.Framework;
using PrototypePattern.Implementation;

namespace PrototypePattern.Tests.Implementation
{
    [TestFixture]
    public class PrototypeTests
    {
        private IFixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _fixture = new Fixture();
        }

        [Test]
        public void Clone_ForManyMembers_ShouldHaveSameNames()
        { 
            // Arrange
            var target = _fixture.Build<Prototype>()
                .With(x => x.DataTypes, _fixture.CreateMany<DataType>(3).ToList)
                .WithAutoProperties()
                .Create();

            // Act
            var result = target.Copy();

            // Assert
            Assert.That(result.Name, Is.EqualTo(target.Name));
        }

        [Test]
        public void Clone_ForManyMembers_ShouldBeDifferentObjects()
        {
            // Arrange
            var target = _fixture.Build<Prototype>()
                .With(x => x.DataTypes, _fixture.CreateMany<DataType>(3).ToList())
                .WithAutoProperties()
                .Create();

            // Act
            var result = target.Copy();

            // Assert
            Assert.That(result, Is.Not.SameAs(target));
        }

        [Test]
        public void Clone_ForManyMembers_ShouldHaveSameAmountOfDataTypes()
        {
            // Arrange
            var target = _fixture.Build<Prototype>()
                .With(x => x.DataTypes, _fixture.CreateMany<DataType>(3).ToList())
                .WithAutoProperties()
                .Create();

            // Act
            var result = target.Copy();

            // Assert
            Assert.That(result.DataTypes.Count, Is.EqualTo(target.DataTypes.Count));
        }

        [Test]
        public void Clone_ForManyMembers_ShouldHaveSameDeepData()
        {
            // Arrange
            var target = _fixture.Build<Prototype>()
                .With(x => x.DataTypes, _fixture.CreateMany<DataType>(3).ToList())
                .WithAutoProperties()
                .Create();

            // Act
            var result = target.Copy();

            // Assert
            Assert.That(GetNamesFromPrototype(result), Is.EqualTo(GetNamesFromPrototype(target)));
        }

        private static IEnumerable<string> GetNamesFromPrototype(Prototype prototype)
        {
            return prototype
                .DataTypes
                .Select(x => x.MemberType)
                .Select(x => x.Name);
        }
    }
}