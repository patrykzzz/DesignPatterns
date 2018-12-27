using Factories.Models.Abstract;

namespace Factories.Implementation.GenericFactory
{
    public class CarFactory
    {
        public Car Create<T>() where T : Car, new()
        {
            return new T();
        }

        private static CarFactory _instance;
        private static readonly object Lock = new object();

        private CarFactory()
        {

        }

        public static CarFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CarFactory();
                    }
                }
            }

            return _instance;
        }
    }
}