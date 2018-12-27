using Factories.Implementation.GenericFactory;
using Factories.Models.Abstract;
using NUnit.Framework;

namespace Factories.Tests.Implementation.GenericFactory
{
    [TestFixture]
    public class CarFactoryTests
    {
        [Test]
        public void Create_ForDifferentTypesOfCar_ShouldReturnProperTypes()
        {
            // Arrange
            var factory = CarFactory.GetInstance();

            // Act
            var electricResult = factory.Create<ElectricCar>();
            var combustionResult = factory.Create<CombustionCar>();
            var hybridResult = factory.Create<HybridCar>();

            // Assert
            Assert.IsInstanceOf<ElectricCar>(electricResult);
            Assert.IsInstanceOf<CombustionCar>(combustionResult);
            Assert.IsInstanceOf<HybridCar>(hybridResult);
        }
    }
}