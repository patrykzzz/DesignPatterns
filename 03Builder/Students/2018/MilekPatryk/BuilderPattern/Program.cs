using System;
using BuilderPattern.Implementation;
using BuilderPattern.Implementation.Abstract;

namespace BuilderPattern
{
    internal class Program
    {
        internal static void Main()
        {
            var director = new Director();

            // PC
            ComputerBuilder builder = new PCBuilder();
            var computer = director.Construct(builder);
            Console.WriteLine(computer);

            // Laptop
            builder = new LaptopBuilder();
            computer = director.Construct(builder);
            Console.WriteLine(computer);

            // Server
            builder = new ServerBuilder();
            computer = director.Construct(builder);
            Console.WriteLine(computer);
        }
    }
}
