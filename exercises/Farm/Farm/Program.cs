using System;

namespace Farm
{
    class Program
    {
           static void Main(string[] args)
           {
               Animal cow = new Animal("Betsy", "cow");
               Animal cow2 = new Animal("Bella", "cow");
               Animal cow3 = new Animal("Bonnie", "cow");
               Animal horse = new Animal("Mr. Ed", "horse");
               Animal horse2 = new Animal("Mayo", "horse");
               Animal horse3 = new Animal("Cloppy", "horse");
               Animal chicken = new Animal("Snap", "chicken");
               Animal chicken2 = new Animal("Crackle", "chicken");
               Animal chicken3 = new Animal("Pop", "chicken");
               Animal dog = new Animal("AJ", "dog");

               cow.speak();
               cow2.speak();
               cow3.speak();
               horse.speak();
               horse2.speak();
               horse3.speak();
               chicken.speak();
               chicken2.speak();
               chicken3.speak();
               dog.speak();
           }
    }
}
