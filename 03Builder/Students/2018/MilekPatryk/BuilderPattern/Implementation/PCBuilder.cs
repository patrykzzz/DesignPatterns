using BuilderPattern.Implementation.Abstract;

namespace BuilderPattern.Implementation
{
    public class PCBuilder : ComputerBuilder
    {
        public override ComputerBuilder BuildMotherboard()
        {
            Computer.Motherboard = "PC motherboard";
            return this;
        }

        public override ComputerBuilder BuildRAM()
        {
            Computer.RAM = "PC RAM";
            return this;
        }

        public override ComputerBuilder BuildCPU()
        {
            Computer.CPU = "PC CPU";
            return this;
        }

        public override ComputerBuilder BuildGPU()
        {
            Computer.GPU = "PC GPU";
            return this;
        }
    }
}