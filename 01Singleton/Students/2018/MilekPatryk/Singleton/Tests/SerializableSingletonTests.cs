using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Xunit;

namespace Singleton.Tests
{
    public class SerializableSingletonTests
    {
        [Fact]
        public void SerializableSingleton_ForSerializeAndDeserializeFromFile_ShouldHaveSameInstance()
        {
            var instance = SerializableSingleton.GetInstance();
            const string fileName = "test.bin";

            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, instance);
            }

            var deserializedResult = new SerializableSingleton[10];
            var file = File.ReadAllBytes(fileName);

            Parallel.For(0, 10, index =>
                {
                    using (var stream = new MemoryStream(file))
                    {
                        var formatter = new BinaryFormatter();
                        deserializedResult[index] = (SerializableSingleton)formatter.Deserialize(stream);
                    }
                });

            Assert.All(deserializedResult, result => Assert.Same(instance, result));
        }
    }
}