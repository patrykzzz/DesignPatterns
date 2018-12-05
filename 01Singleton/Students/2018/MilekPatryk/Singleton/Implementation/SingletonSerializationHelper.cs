using System;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Singleton
{
    [Serializable]
    public class SingletonSerializationHelper : IObjectReference
    {
        public object GetRealObject(StreamingContext context)
        {
            return SerializableSingleton.GetInstance();
        }
    }
}