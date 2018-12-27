using System;
using Factories.Models.Abstract;

namespace Factories.Implementation.AbstractFactory
{
    public static class AbstractClient
    {
        public static Car GetCar(string manufacturer, string carType)
        {
            Car car;
            Abstract.AbstractFactory factory;

            switch (manufacturer)
            {
                case "Hyundai":
                    factory = HyundaiConcreteFactory.GetInstance();
                    break;
                case "Toyota":
                    factory = ToyotaConcreteFactory.GetInstance();
                    break;
                case "Tesla":
                    factory = TeslaConcreteFactory.GetInstance();
                    break;
                default:
                    throw new Exception("Unsupported manufacturer.");
            }

            switch (carType)
            {
                case "Combustion":
                    car = factory.CreateCombustionCar();
                    break;
                case "Electric":
                    car = factory.CreateElectricCar();
                    break;
                case "Hybrid":
                    car = factory.CreateHybridCar();
                    break;
                default:
                    throw new Exception($"Unsupported car type for manufacturer {manufacturer}.");
            }

            return car;
        }
    }
}