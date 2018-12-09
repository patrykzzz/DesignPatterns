using Factories.Models.Abstract;

namespace Factories.Implementation.Simple.Abstract
{
    public interface ISimpleFactory
    {
        Car Create(string type);
    }
}