using NUnit.Framework;
using _02TwoWayAdapter;

namespace _02TwoWayAdapterTests
{
    [TestFixture]
    public class SeabirdTests
    {
        [Test]
        public void Seabird_ForNewObject_ShouldReturnSeacraft()
        {
            var seacraft = new Seabird();

            Assert.That(seacraft, Is.AssignableTo<Seacraft>());
        }
    }
}