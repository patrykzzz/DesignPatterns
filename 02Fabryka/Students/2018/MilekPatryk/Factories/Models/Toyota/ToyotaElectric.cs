using Factories.Models.Abstract;

namespace Factories.Models.Toyota
{
    public class ToyotaElectric : ElectricCar
    {
        public ToyotaElectric()
        {
            Name = "Toyota Mirai";
            Price = 135000;
            BatterySize = 18;
        }
    }
}