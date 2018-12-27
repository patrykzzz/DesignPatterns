using Factories.Models.Abstract;
using Factories.Models.Toyota;

namespace Factories.Implementation.AbstractFactory
{
    public class ToyotaConcreteFactory : Abstract.AbstractFactory
    {

        public override CombustionCar CreateCombustionCar()
        {
            return new ToyotaCombustion();
        }

        public override ElectricCar CreateElectricCar()
        {
            return new ToyotaElectric();
        }

        public override HybridCar CreateHybridCar()
        {
            return new ToyotaHybrid();
        }

        private static ToyotaConcreteFactory _instance;
        private static readonly object Lock = new object();

        private ToyotaConcreteFactory()
        {

        }

        public static ToyotaConcreteFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ToyotaConcreteFactory();
                    }
                }
            }
            return _instance;
        }
    }
}