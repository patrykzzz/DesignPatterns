using Factories.Models.Abstract;

namespace Factories.Models.Tesla
{
    public class TeslaCombustion : CombustionCar
    {
        public TeslaCombustion()
        {
            Name = "Tesla Combustion";
            Price = 135000;
            EngineSize = 3.0;
        }
    }
}