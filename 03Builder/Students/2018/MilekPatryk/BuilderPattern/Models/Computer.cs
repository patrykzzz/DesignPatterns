namespace BuilderPattern.Models
{
    public class Computer
    {
        public string Motherboard { get; set; }
        public string RAM { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }

        public override string ToString()
        {
            return $"Motherboard: {Motherboard}, RAM: {RAM}, CPU: {CPU}, GPU: {GPU}";
        }
    }
}