using Factories.Implementation.GenericFactory;
using Factories.Models.Abstract;
using Factories.Models.Tesla;
using Factories.Models.Toyota;
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
            var factory = GenericCarFactory.GetInstance();

            // Act
            var teslaCombustionResult = factory.Create<TeslaCombustion>();
            var teslaModel3Result = factory.Create<TeslaModel3>();
            var toyotaCombustionResult = factory.Create<ToyotaCombustion>();

            // Assert
            Assert.IsInstanceOf<TeslaCombustion>(teslaCombustionResult);
            Assert.IsInstanceOf<TeslaModel3>(teslaModel3Result);
            Assert.IsInstanceOf<ToyotaCombustion>(toyotaCombustionResult);
        }

        [Test]
        public void Create_RegisterAndCreateNewType_ShouldSucceed()
        {
            // Arrange
            var factory = GenericCarFactory.GetInstance();

            // Act
            var resultBeforeRegistration = factory.Create<ElectricCar>();
            factory.RegisterCarType(typeof(ElectricCar));
            var resultAfterRegistration = factory.Create<ElectricCar>();

            // Assert
            Assert.That(resultBeforeRegistration, Is.Null);
            Assert.That(resultAfterRegistration, Is.TypeOf<ElectricCar>());
        }

    }
}