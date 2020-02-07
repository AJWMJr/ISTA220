using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal("betsy", "cow");
            Animal horse = new Animal("Mr. Ed", "horse");
            Animal chicken = new Animal("daisy", "chicken");
            Animal bird = new Animal("AJ", "bird");
            cow.speak();
            horse.speak();
            chicken.speak();
            bird.speak();
        }
    }
}
