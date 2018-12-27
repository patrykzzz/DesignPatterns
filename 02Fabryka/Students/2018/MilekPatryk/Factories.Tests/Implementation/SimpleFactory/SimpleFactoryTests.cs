using Factories.Models.Abstract;
using NUnit.Framework;

namespace Factories.Tests.Implementation.SimpleFactory
{
    [TestFixture]
    public class SimpleFactoryTests
    {
        [Test]
        public void Create_Electric_ShouldReturnElectricCar()
        {
            // Arrange
            var factory = Factories.Implementation.SimpleFactory.SimpleFactory.GetInstance();

            // Act
            var result = factory.Create("Electric");

            // Assert
            Assert.That(result, Is.TypeOf<ElectricCar>());
            Assert.That(result, Is.AssignableTo<Car>());
        }
    }
}
