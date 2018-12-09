using Factories.Models.Abstract;

namespace Factories.Models.Hyundai
{
    public class HyundaiHybrid : HybridCar
    {
        public HyundaiHybrid()
        {
            Name = "Hyundai Ionic Hybrid";
            Price = 100000;
            BatterySize = 10;
            EngineSize = 2.5;
        }
    }
}