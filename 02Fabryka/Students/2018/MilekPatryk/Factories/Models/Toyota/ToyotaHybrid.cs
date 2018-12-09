using Factories.Models.Abstract;

namespace Factories.Models.Toyota
{
    public class ToyotaHybrid : HybridCar
    {
        public ToyotaHybrid()
        {
            Name = "Toyota RAV4 Hybrid";
            Price = 200000;
            BatterySize = 13;
            EngineSize = 2.5;
        }
    }
}