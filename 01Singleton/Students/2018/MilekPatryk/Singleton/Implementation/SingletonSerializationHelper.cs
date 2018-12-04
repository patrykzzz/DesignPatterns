// ReSharper disable once CheckNamespace
using System;
using System.Runtime.Serialization;

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