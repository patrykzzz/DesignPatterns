using BuilderPattern.Implementation.Abstract;

namespace BuilderPattern.Implementation
{
    public class ServerBuilder : ComputerBuilder
    {
        public override ComputerBuilder BuildMotherboard()
        {
            Computer.Motherboard = "Server motherboard";
            return this;
        }

        public override ComputerBuilder BuildRAM()
        {
            Computer.RAM = "Server RAM";
            return this;
        }

        public override ComputerBuilder BuildCPU()
        {
            Computer.CPU = "Server CPU";
            return this;
        }

        public override ComputerBuilder BuildGPU()
        {
            Computer.GPU = "Server GPU";
            return this;
        }
    }
}