using Factories.Models.Abstract;

namespace Factories.Implementation.AbstractFactory.Abstract
{
    public abstract class AbstractFactory
    {
        public abstract CombustionCar CreateCombustionCar();
        public abstract ElectricCar CreateElectricCar();
        public abstract HybridCar CreateHybridCar();
    }
}