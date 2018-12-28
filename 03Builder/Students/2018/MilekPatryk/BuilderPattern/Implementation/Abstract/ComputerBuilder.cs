using BuilderPattern.Models;

namespace BuilderPattern.Implementation.Abstract
{
    public abstract class ComputerBuilder
    {
        protected ComputerBuilder()
        {
            Computer = new Computer();
        }

        protected Computer Computer { get; set; }

        public abstract ComputerBuilder BuildMotherboard();
        public abstract ComputerBuilder BuildRAM();
        public abstract ComputerBuilder BuildCPU();
        public abstract ComputerBuilder BuildGPU();

        public static explicit operator Computer(ComputerBuilder builder)
        {
            return builder.Computer;
        }
    }
}