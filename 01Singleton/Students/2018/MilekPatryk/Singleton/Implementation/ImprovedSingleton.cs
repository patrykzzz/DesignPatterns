// ReSharper disable once CheckNamespace
namespace Singleton
{
    public class ImprovedSingleton
    {
        private static ImprovedSingleton _instance;

        private static readonly object Lock = new object();

        private ImprovedSingleton()
        {

        }

        public static ImprovedSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ImprovedSingleton();
                    }
                }
            }

            return _instance;
        }
    }
}
