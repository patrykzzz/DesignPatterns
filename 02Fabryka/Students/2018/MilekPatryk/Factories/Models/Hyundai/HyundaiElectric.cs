using Factories.Models.Abstract;

namespace Factories.Models.Hyundai
{
    public class HyundaiElectric : ElectricCar
    {
        public HyundaiElectric()
        {
            Name = "Hyundai Ionic Electric";
            Price = 150000;
            BatterySize = 25;
        }
    }
}