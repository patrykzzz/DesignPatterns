using System;
using System.Collections.Generic;
using System.Linq;
using PrototypePattern.Implementation;
using PrototypePattern.Implementation.Abstract;

namespace PrototypePattern
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            BasePrototype<Prototype> prototype = new Prototype("Test", "Description", new List<DataType>
            {
                new DataType
                {
                    MemberType = new MemberType
                    {
                        Name = "TestDeep"
                    }
                }
            });

            var copy = prototype.Copy();

            Console.WriteLine(copy.DataTypes.First().MemberType.Name);
        }
    }
}
