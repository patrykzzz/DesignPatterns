using Factories.Models.Abstract;
using Factories.Models.Hyundai;

namespace Factories.Implementation.AbstractFactory
{
    public class HyundaiConcreteFactory : Abstract.AbstractFactory
    {
        public override CombustionCar CreateCombustionCar()
        {
            return new HyundaiCombustion();
        }

        public override ElectricCar CreateElectricCar()
        {
            return new HyundaiElectric();
        }

        public override HybridCar CreateHybridCar()
        {
            return new HyundaiHybrid();
        }
        
        private static HyundaiConcreteFactory _instance;
        private static readonly object Lock = new object();

        private HyundaiConcreteFactory()
        {

        }

        public static HyundaiConcreteFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new HyundaiConcreteFactory();
                    }
                }
            }

            return _instance;
        }
    }
}