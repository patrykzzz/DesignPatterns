using Factories.Models.Abstract;

namespace Factories.Implementation.SimpleFactory.Abstract
{
    public interface ISimpleFactory
    {
        Car Create(string type);
    }
}