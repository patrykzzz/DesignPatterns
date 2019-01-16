using System;
using System.Collections.Generic;
using System.Linq;
using Factories.Models.Abstract;
using Factories.Models.Hyundai;
using Factories.Models.Tesla;
using Factories.Models.Toyota;

namespace Factories.Implementation.GenericFactory
{
    public class GenericCarFactory
    {
        private readonly List<Type> CarTypes;

        public Car Create<T>() where T : Car, new()
        {
            return CarTypes.Contains(typeof(T)) ? new T() : null;
        }

        private GenericCarFactory()
        {
            CarTypes = new List<Type>
            {
                typeof(HyundaiCombustion), typeof(HyundaiElectric), typeof(HyundaiHybrid),
                typeof(ToyotaCombustion), typeof(ToyotaElectric), typeof(ToyotaHybrid),
                typeof(TeslaModelS), typeof(TeslaModel3), typeof(TeslaHybrid), typeof(TeslaCombustion)
            };
        }

        public void RegisterCarType(Type carType)
        {
            if (!carType.IsAbstract && carType.IsSubclassOf(typeof(Car)) 
                && carType.GetConstructor(Type.EmptyTypes) != null && !CarTypes.Contains(carType))
            {
                CarTypes.Add(carType);
            }
        }

        private static GenericCarFactory _instance;
        private static readonly object Lock = new object();

        public static GenericCarFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new GenericCarFactory();
                    }
                }
            }
            return _instance;
        }
    }
}