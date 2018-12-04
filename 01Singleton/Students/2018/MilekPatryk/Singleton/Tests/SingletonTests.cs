using System.Threading.Tasks;
using Xunit;

namespace Singleton.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void GetInstance_ForThousandCopies_ShouldHaveSameInstance()
        {
            // Arrange
            var instances = new Singleton[10];

            // Act
            Parallel.For(0, 10, index => instances[index] = Singleton.GetInstance());

            // Assert
            var expectedInstance = Singleton.GetInstance();
            Assert.All(instances, instance => Assert.Same(expectedInstance, instance));
        }

        [Fact]
        public void GetInstance_ForTwoCopies_ShouldHaveSameInstance()
        {
            // Arrange & Act
            var firstInstance = Singleton.GetInstance();
            var secondInstance = Singleton.GetInstance();
            
            // Assert
            Assert.Same(firstInstance, secondInstance);
        }
    }
}