using Factories.Implementation.FactoryMethod;
using Factories.Implementation.SimpleFactory.Abstract;
using Factories.Models.Abstract;
using Factories.Models.Hyundai;
using NUnit.Framework;

namespace Factories.Tests.Implementation.FactoryMethod
{
    [TestFixture]
    public class HyundaiFactoryTests
    {
        [Test]
        public void HyundaiFactory_Fori30_ShouldReturnHyundaiCombustion()
        {
            // Arrange
            ISimpleFactory factory = HyundaiFactory.GetInstance();

            // Act
            var result = factory.Create("i30");

            // Assert
            Assert.That(result, Is.TypeOf<HyundaiCombustion>());
            Assert.That(result, Is.AssignableTo<Car>());
        }
    }
}