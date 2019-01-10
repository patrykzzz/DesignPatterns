using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Factories.Models.Abstract;
using Factories.Models.Hyundai;

namespace Factories.Implementation.ReflectionFactory
{
    public class ReflectionFactory
    {
        public Car Create(string name)
        {
            CarTypeDictionary.TryGetValue(name, out var type);

            if (type == null)
            {
                throw new Exception("Car with given parameters is not supported.");
            }
            return (Car) Assembly.GetExecutingAssembly().CreateInstance(type.ToString());
        }

        private readonly Dictionary<string, Type> CarTypeDictionary;


        private static ReflectionFactory _instance;
        private static readonly object Lock = new object();

        private ReflectionFactory()
        {
            var types = Assembly.GetAssembly(typeof(Car))
                .GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Car)) && !x.IsAbstract);
            CarTypeDictionary = types.ToDictionary(x => x.Name, x => x);
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