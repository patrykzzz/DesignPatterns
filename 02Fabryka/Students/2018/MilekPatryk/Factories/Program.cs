using System;
using Factories.Implementation.AbstractFactory;
using Factories.Implementation.GenericFactory;
using Factories.Models.Hyundai;
using Factories.Models.Toyota;

namespace Factories
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Provide manufacturer: ");
            var manufacturer = Console.ReadLine();
            Console.Write("Provide car type: ");
            var carType = Console.ReadLine();

            // Abstract factory
            var car = AbstractClient.GetCar(manufacturer, carType);
            Console.WriteLine($"Created car's name: {car.Name}");

            // Generic factory
            var factory = GenericCarFactory.GetInstance();

            car = factory.Create<ToyotaCombustion>();
            Console.WriteLine($"Generic created toyota combustion car's name: {car.Name}, type: {car.GetType()}");

            car = factory.Create<HyundaiElectric>();
            Console.WriteLine($"Generic created hyundai electric car's name: {car.Name}, type: {car.GetType()}");
        }
    }
}
