using Factories.Implementation.Simple.Abstract;
using Factories.Models.Abstract;
using Factories.Models.Toyota;

namespace Factories.Implementation.Simple
{
    public class ToyotaSimpleFactory : ISimpleFactory
    {
        public Car Create(string type)
        {
            switch (type)
            {
                case "Avalon":
                    return new ToyotaCombustion();
                case "RAV4 Hybrid":
                    return new ToyotaHybrid();
                case "Mirai":
                    return new ToyotaElectric();
                default:
                    return null;
            }
        }

        private static ToyotaSimpleFactory _instance;
        private static readonly object Lock = new object();

        private ToyotaSimpleFactory()
        {

        }

        public static ToyotaSimpleFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ToyotaSimpleFactory();
                    }
                }
            }
            return _instance;
        }
    }
}