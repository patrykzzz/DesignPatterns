using Factories.Models.Abstract;

namespace Factories.Models.Tesla
{
    public class TeslaModelS : ElectricCar
    {
        public TeslaModelS()
        {
            Name = "Tesla Model 3";
            Price = 100000;
            BatterySize = 15;
        }
    }
}