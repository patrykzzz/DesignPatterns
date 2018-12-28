using BuilderPattern.Implementation.Abstract;

namespace BuilderPattern.Implementation
{
    public class LaptopBuilder : ComputerBuilder
    {
        public override ComputerBuilder BuildMotherboard()
        {
            Computer.Motherboard = "Laptop motherboard";
            return this;
        }

        public override ComputerBuilder BuildRAM()
        {
            Computer.RAM = "Laptop RAM";
            return this;
        }

        public override ComputerBuilder BuildCPU()
        {
            Computer.CPU = "Laptop CPU";
            return this;
        }

        public override ComputerBuilder BuildGPU()
        {
            Computer.GPU = "Laptop GPU";
            return this;
        }
    }
}