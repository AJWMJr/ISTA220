using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            Console.WriteLine("MM        MM  SSSSSSSS  SSSSSSSS       AAAAAA");
            Console.WriteLine("MMM      MMM  SSSSSSSS  SSSSSSSS       AA  AA");
            Console.WriteLine("MMMM    MMMM  SS        SS            AA    AA");
            Console.WriteLine("MM MM  MM MM  SS        SS            AA    AA");
            Console.WriteLine("MM  MMMM  MM  SSSSSSSS  SSSSSSSS     AAAAAAAAA");
            Console.WriteLine("MM   MM   MM  SSSSSSSS  SSSSSSSS     AAAAAAAAA");
            Console.WriteLine("MM        MM        SS        SS     AA      AA");
            Console.WriteLine("MM        MM        SS        SS     AA      AA");
            Console.WriteLine("MM        MM  SSSSSSSS  SSSSSSSS     AA      AA");
            Console.WriteLine("MM        MM  SSSSSSSS  SSSSSSSS     AA      AA");

            Console.WriteLine(" ");
            Console.WriteLine("Part 2");
            double phi = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"phi is {phi}");
        }
    }
}
