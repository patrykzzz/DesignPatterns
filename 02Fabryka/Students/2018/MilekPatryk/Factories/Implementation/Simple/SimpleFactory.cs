namespace Factories.Implementation.Simple
{
    public class SimpleFactory
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
    }
}