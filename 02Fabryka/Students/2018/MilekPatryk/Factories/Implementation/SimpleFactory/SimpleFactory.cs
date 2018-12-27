using Factories.Implementation.SimpleFactory.Abstract;
using Factories.Models.Abstract;

namespace Factories.Implementation.SimpleFactory
{
    public class SimpleFactory : ISimpleFactory
    {
        private static SimpleFactory _instance;
        private static readonly object Lock = new object();

        private SimpleFactory()
        {

        }

        public static SimpleFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleFactory();
                    }
                }
            }

            return _instance;
        }

        public Car Create(string type)
        {
            switch (type)
            {
                case "Combustion":
                    return new CombustionCar();
                case "Electric":
                    return new ElectricCar();
                case "Hybrid":
                    return new HybridCar();
                default:
                    return null;
            }
        }
    }
}