using System;

namespace Cssbs_EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            Rank Erank = new Rank('E', 5);
            Rank Orank = new Rank('O', 2);
            Rifle R1 = new Rifle();
            Rifle R2 = new Rifle();
            Generator G = new Generator();
            Enlisted E = new Enlisted(Erank,R2,G);
            Officer O = new Officer(Orank,R1,G);
            HumV V = new HumV(30, 1165, E, O);
            V.Speak();
        }
    }
    internal class Personnel
    {
        public virtual void Speak()
        {
            Console.WriteLine("Speak currently undefined");
        }
    }
    internal class Rank
    {
        private char rank;
        private int num;
        public Rank(char rank = 'E', int a = 1)
        {
            if (rank == 'E' || rank == 'O')
            {
                this.rank = rank;
                this.num = a;
            }
            else
                Console.WriteLine("incorrect rank identifier");
        }
        public string getRank()
        {
            string rankN = this.num.ToString();
            string realRank = this.rank + rankN;
            return realRank;
        }
    }
    internal class Weapon
    {
        public virtual void Fire()
        {
            Console.WriteLine("Fire not implemented");
        }
    }
    internal class Equipment 
    {
        public virtual void Use()
        {
            Console.WriteLine("Use not implemented");
        }
    }
    internal class HumV
    {
        int age, type;
        Enlisted E;
        Officer O;
        public HumV(int age, int type, Enlisted E, Officer O)
        {
            this.age = age;
            this.type = type;
            this.E = E;
            this.O = O;
        }
        public void Speak()
        {
            Console.WriteLine($"I am a HumV and my model # is {type} I have beeen around for {age} years");
            Console.WriteLine("I have 2 passengers");
            Console.WriteLine("they are an Enlisted: ");
            E.Speak();
            Console.WriteLine("and an Officer: ");
            O.Speak();
        }
    }

    internal class Generator : Equipment
    {
        string type = "Generator";
        string noise;
        public Generator(string noise = "Vrrr")
        {
            this.noise = noise;
        }
        public string getType()
        {
            return type;
        }
        public override void Use()
        {
            Console.WriteLine($"I am a Generator and I go {noise}");
        }
    }

    internal class Rifle : Weapon
    {
        string type = "Rifle";
        string noise;
        public Rifle(string noise = "Bang")
        {
            this.noise = noise;
        }
        public string getType()
        {
            return type;
        }
        public string getNoise()
        {
            return noise;
        }
        public override void Fire()
        {
            Console.WriteLine($"I am a {type} and I go {noise}");
        }
    }

    internal class Officer : Personnel
    {
        Rank rank = new Rank();
        Rifle W = new Rifle();
        Generator E = new Generator();
        public Officer(Rank rank, Rifle W, Generator E)
        {
            this.rank = rank;
            this.W = W;
            this.E = E;
        }
        public override void Speak()
        {
            Console.WriteLine("I am an Officer");
            Console.WriteLine($"My rank is {rank.getRank()}");
            Console.WriteLine($"I have a {W.getType()} and it goes {W.getNoise()}");
            Console.WriteLine($"I have a {E.getType()}");
        }
    }

    internal class Enlisted : Personnel
    {
        Rank rank = new Rank();
        Rifle W = new Rifle();
        Generator E = new Generator();
        public Enlisted(Rank rank, Rifle W, Generator E)
        {
            this.rank = rank;
            this.W = W;
            this.E = E;
        }
        public override void Speak()
        {
            Console.WriteLine("I am an Enlisted military member");
            Console.WriteLine($"My rank is {rank.getRank()}");
            Console.WriteLine($"I have a {W.getType()} and it goes {W.getNoise()}");
            Console.WriteLine($"I have a {E.getType()}");
        }
    }
}
