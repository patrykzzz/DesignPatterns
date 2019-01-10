using Factories.Models.Hyundai;
using NUnit.Framework;

namespace Factories.Tests.Implementation.ReflectionFactory
{
    [TestFixture]
    public class ReflectionFactoryTests
    {
        [Test]
        public void Create_ForExistingManufacturersAndTypes_ShouldCreateCorrectInstances()
        {
            // Arrange
            var factory = Factories.Implementation.ReflectionFactory.ReflectionFactory.GetInstance();

            // Act
            var combustionHyundai = factory.Create("HyundaiCombustion");
            var electricHyundai = factory.Create("HyundaiElectric");
            var hybridHyundai = factory.Create("HyundaiHybrid");

            // Assert
            Assert.IsInstanceOf<HyundaiCombustion>(combustionHyundai);
            Assert.IsInstanceOf<HyundaiElectric>(electricHyundai);
            Assert.IsInstanceOf<HyundaiHybrid>(hybridHyundai);
            Assert.That(hybridHyundai.Name, Is.EqualTo("Hyundai Ionic Hybrid"));
        }
    }
}