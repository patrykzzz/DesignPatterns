using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

// ReSharper disable once CheckNamespace
namespace Singleton
{
    [Serializable]
    public class SerializableSingleton : ISerializable
    {
        private static SerializableSingleton _instance;

        private static readonly object Lock = new object();

        private SerializableSingleton()
        {

        }

        public static SerializableSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SerializableSingleton();
                    }
                }
            }

            return _instance;
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.SetType(typeof(SingletonSerializationHelper));
        }
    }
}