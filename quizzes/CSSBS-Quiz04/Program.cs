using System;

namespace CSSBS_Quiz04
{
    class Firearm
    {
        public string kind, noise;
        public Firearm(string kind)
        {
           this.kind = kind;
        }

        public void Fire()
        {
            if (kind == "shotgun")
            {
                noise = "Boom";
            }
            else if (kind == "rifle")
            {
                noise = "Bang";
            }
            else
            {
                noise = "pop";
            }
            Console.WriteLine($"I am a {kind} and I go {noise}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Test 04");
            Firearm shotgun = new Firearm("shotgun");
            Firearm rifle = new Firearm("rifle");
            Firearm pistol = new Firearm("pistol");
            shotgun.Fire();
            rifle.Fire();
            pistol.Fire();
        }
    }
}
