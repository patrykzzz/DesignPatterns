using Factories.Implementation.Simple.Abstract;
using Factories.Models.Abstract;
using Factories.Models.Hyundai;

namespace Factories.Implementation.Simple
{
    public class HyundaiSimpleFactory : ISimpleFactory
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

        private static HyundaiSimpleFactory _instance;
        private static readonly object Lock = new object();

        private HyundaiSimpleFactory()
        {

        }

        public static HyundaiSimpleFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new HyundaiSimpleFactory();
                    }
                }
            }

            return _instance;
        }
    }
}