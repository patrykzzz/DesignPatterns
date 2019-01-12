namespace _02TwoWayAdapter
{
    public class ModifiedSeabird : ISeacraft, IAircraft
    {
        private readonly Aircraft Aircraft;
        private readonly Seacraft Seacraft;

        public ModifiedSeabird()
        {
            Aircraft = new Aircraft();
            Seacraft = new Seacraft();
        }

        public int Speed => Seacraft.Speed;

        public void IncreaseRevs()
        {
            Seacraft.IncreaseRevs();
            if (Seacraft.Speed > 40)
            {
                Aircraft.Height += 100;
            }
        }

        public bool Airborne => Aircraft.Airborne;

        public void TakeOff()
        {
            Aircraft.TakeOff();
        }

        public int Height => Aircraft.Height;
    }
}