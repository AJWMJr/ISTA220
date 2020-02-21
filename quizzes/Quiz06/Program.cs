using System;

namespace Quiz06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Quiz06");
            Firearm F = new Firearm();
            Shotgun S = new Shotgun();
            Rifle R = new Rifle();
            Pistol P = new Pistol();
            F.purpose();
            S.purpose();
            R.purpose();
            P.purpose();
        }
    }
    internal class Firearm
    {
        public virtual void purpose()
        {
            Console.WriteLine("I am a firearm and I shoot things");
        }
    }
    internal class Pistol : Firearm
    {
        public override void purpose()
        {
            Console.WriteLine("I am a pistol and I go pop");
        }
    }
    internal class Rifle : Firearm
    {
        public override void purpose()
        {
            Console.WriteLine("I am a Rifle and I Bang");
        }
    }
    internal class Shotgun : Firearm
    {
        public override void purpose()
        {
            Console.WriteLine("I am a Shotgun and I go Boom");
        }
    }
}
