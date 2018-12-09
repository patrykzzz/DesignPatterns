using Factories.Implementation.Simple.Abstract;
using Factories.Models.Abstract;
using Factories.Models.Tesla;

namespace Factories.Implementation.Simple
{
    public class TeslaSimpleFactory : ISimpleFactory
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

        private static TeslaSimpleFactory _instance;
        private static readonly object Lock = new object();

        private TeslaSimpleFactory()
        {

        }

        public static TeslaSimpleFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TeslaSimpleFactory();
                    }
                }
            }

            return _instance;
        }
    }
}