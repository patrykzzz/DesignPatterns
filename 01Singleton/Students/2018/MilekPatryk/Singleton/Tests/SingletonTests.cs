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
            var instances = new ImprovedSingleton[1000];

            // Act
            Parallel.For(0, 1000, index => instances[index] = ImprovedSingleton.GetInstance());

            // Assert
            var expectedInstance = ImprovedSingleton.GetInstance();
            Assert.All(instances, instance => Assert.Same(expectedInstance, instance));
        }

        [Fact]
        public void GetInstance_ForTwoCopies_ShouldHaveSameInstance()
        {
            // Arrange & Act
            var firstInstance = ImprovedSingleton.GetInstance();
            var secondInstance = ImprovedSingleton.GetInstance();
            
            // Assert
            Assert.Same(firstInstance, secondInstance);
        }
    }
}