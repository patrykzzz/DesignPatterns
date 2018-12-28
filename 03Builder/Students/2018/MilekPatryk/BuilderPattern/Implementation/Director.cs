using BuilderPattern.Implementation.Abstract;
using BuilderPattern.Models;

namespace BuilderPattern.Implementation
{
    public class Director
    {
        public Computer Construct(ComputerBuilder builder)
        {
            return (Computer) builder.BuildMotherboard()
                .BuildRAM()
                .BuildCPU()
                .BuildGPU();
        }
    }
}