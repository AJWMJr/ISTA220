using System;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

         /* 
          * Calculator calculator = new Calculator();
          * Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
          * int dividend = calculator.Divide(120, 15);
          * Console.WriteLine($"dividend is {dividend}");
          */

            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"dividend = {calculator.Divide(120, 0)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
