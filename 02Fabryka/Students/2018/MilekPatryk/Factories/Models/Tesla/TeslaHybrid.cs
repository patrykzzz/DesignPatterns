using Factories.Models.Abstract;

namespace Factories.Models.Tesla
{
    public class TeslaHybrid : HybridCar
    {
        public TeslaHybrid()
        {
            Name = "Tesla Hybrid";
            BatterySize = 2;
            Price = 250000;
            EngineSize = 2.3;
        }
    }
}