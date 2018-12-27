using Factories.Models.Abstract;
using Factories.Models.Tesla;

namespace Factories.Implementation.AbstractFactory
{
    public class TeslaConcreteFactory : Abstract.AbstractFactory
    {
        public override CombustionCar CreateCombustionCar()
        {
            return new TeslaCombustion();
        }

        public override ElectricCar CreateElectricCar()
        {
            return new TeslaModel3();
        }

        public override HybridCar CreateHybridCar()
        {
            return new TeslaHybrid();
        }

        private static TeslaConcreteFactory _instance;
        private static readonly object Lock = new object();

        private TeslaConcreteFactory()
        {

        }

        public static TeslaConcreteFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TeslaConcreteFactory();
                    }
                }
            }
            return _instance;
        }
    }
}