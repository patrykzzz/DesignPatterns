using Factories.Implementation.SimpleFactory.Abstract;
using Factories.Models.Abstract;
using Factories.Models.Tesla;

namespace Factories.Implementation.FactoryMethod
{
    public class TeslaFactory : ISimpleFactory
    {
        public Car Create(string type)
        {
            switch (type)
            {
                case "Model S":
                    return new TeslaModelS();
                case "Model 3":
                    return new TeslaModel3();
                default:
                    return null;
            }
        }

        private static TeslaFactory _instance;
        private static readonly object Lock = new object();

        private TeslaFactory()
        {

        }

        public static TeslaFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TeslaFactory();
                    }
                }
            }

            return _instance;
        }
    }
}