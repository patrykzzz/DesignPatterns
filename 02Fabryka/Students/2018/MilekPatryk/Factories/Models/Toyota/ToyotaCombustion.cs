using Factories.Models.Abstract;

namespace Factories.Models.Toyota
{
    public class ToyotaCombustion : CombustionCar
    {
        public ToyotaCombustion()
        {
            Name = "Toyota Avalon";
            Price = 100000;
            EngineSize = 2.8;
        }
    }
}