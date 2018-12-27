using Factories.Implementation.SimpleFactory.Abstract;
using Factories.Models.Abstract;
using Factories.Models.Hyundai;

namespace Factories.Implementation.FactoryMethod
{
    public class HyundaiFactory : ISimpleFactory
    {
        public Car Create(string type)
        {
            switch (type)
            {
                case "Ionic Electric":
                    return new HyundaiElectric();
                case "Ionic Hybrid":
                    return new HyundaiHybrid();
                case "i30":
                    return new HyundaiCombustion();
                default:
                    return null;
            }
        }
        
        private static HyundaiFactory _instance;
        private static readonly object Lock = new object();

        private HyundaiFactory()
        {

        }

        public static HyundaiFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new HyundaiFactory();
                    }
                }
            }

            return _instance;
        }
    }
}