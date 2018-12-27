using System;
using System.Collections.Generic;
using System.Reflection;
using Factories.Models.Abstract;
using Factories.Models.Hyundai;

namespace Factories.Implementation.ReflectionFactory
{
    public class ReflectionFactory
    {
        public Car Create(string manufacturer, string carType)
        {
            CarTypeDictionary.TryGetValue((manufacturer, carType), out var type);
            if (type == null)
            {
                throw new Exception("Car with given parameters is not supported.");
            }
            return (Car) Assembly.GetExecutingAssembly().CreateInstance(type.ToString());
        }

        private static readonly Dictionary<(string, string), Type> CarTypeDictionary = new Dictionary<(string, string), Type>
        {
            { ("Hyundai", "Electric"), typeof(HyundaiElectric) },
            { ("Hyundai", "Combustion"), typeof(HyundaiCombustion) },
            { ("Hyundai", "Hybrid"), typeof(HyundaiHybrid) },
        };


        private static ReflectionFactory _instance;
        private static readonly object Lock = new object();

        private ReflectionFactory()
        {

        }

        public static ReflectionFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ReflectionFactory();
                    }
                }
            }

            return _instance;
        }
    }
}