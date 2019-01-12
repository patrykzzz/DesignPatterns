using System;

namespace _02TwoWayAdapter
{
    // Target
    public sealed class Aircraft : IAircraft
    {
        int height;
        bool airborne;
        public Aircraft()
        {
            height = 0;
            airborne = false;
        }
        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = true;
            height = 200; // Meters
        }
        public bool Airborne
        {
            get { return airborne; }
        }
        public int Height { get; set; }
    }
}
