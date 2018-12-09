using Factories.Models.Abstract;

namespace Factories.Models.Tesla
{
    public class TeslaModel3 : ElectricCar
    {
        public TeslaModel3()
        {
            Name = "Tesla Model S";
            Price = 300000;
            BatterySize = 20;
        }
    }
}