using System;
using System.Collections.Generic;
using System.Linq;
using PrototypePattern.Implementation.Abstract;

namespace PrototypePattern.Implementation
{
    [Serializable]
    public class Prototype : BasePrototype<Prototype>
    {
        public Prototype()
        {
            
        }

        public Prototype(string name, string description, IEnumerable<DataType> dataTypes)
        {
            Name = name;
            Description = description;
            DataTypes = dataTypes.ToList();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<DataType> DataTypes { get; set; }
    }
}