using Factories.Models.Abstract;

namespace Factories.Models.Hyundai
{
    public class HyundaiCombustion : CombustionCar
    {
        public HyundaiCombustion()
        {
            Name = "Hyundai i30";
            Price = 100000;
            EngineSize = 2.0;
        }
    }
}