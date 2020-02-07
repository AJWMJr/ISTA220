using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area and Circumference of a Circle");
            Console.WriteLine("enter a number for radius");
            string radius = Console.ReadLine();
            int intRadius = int.Parse(radius);
            double circum = 2 * Math.PI * intRadius;
            Console.WriteLine($"The Circumference is {circum}");
            double area = Math.PI * intRadius * intRadius;
            Console.WriteLine($"The Area is {area}");

            Console.WriteLine("Volume of a hemisphere");
            Console.WriteLine("enter a number for radius");
            radius = Console.ReadLine();
            intRadius = int.Parse(radius);
            double volume = (1.33333333 * Math.PI * intRadius * intRadius * intRadius) / 2;
            Console.WriteLine($"The Volume of this Hemisphere is {volume}");

            Console.WriteLine("Area of a Triangle");
            Console.WriteLine("enter values for the three sides");
            string sA = Console.ReadLine();
            int intSA = int.Parse(sA);
            string sB = Console.ReadLine();
            int intSB = int.Parse(sB);
            string sC = Console.ReadLine();
            int intSC = int.Parse(sC);
            double perim = (intSA + intSB + intSC) / 2;
            area = Math.Sqrt(perim * (perim - intSA) * (perim - intSB) * (perim - intSC));
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("The quadratic equation");
            Console.WriteLine("Enter the coefficients");
            string first = Console.ReadLine();
            int intF = int.Parse(first);
            string second = Console.ReadLine();
            int intS = int.Parse(second);
            string third = Console.ReadLine();
            int intT = int.Parse(third);
            int intA = 2 * intF;
            double solutionPos = (-1 * intS) + Math.Sqrt((intS * intS) - (4 * intF * intT)) / (2 * intA);
            double solutionNeg = (-1 * intS) - Math.Sqrt((intS * intS) - (4 * intF * intT)) / (2 * intA);
            Console.WriteLine($"The positive solution is {solutionPos}");
            Console.WriteLine($"The negative solution is {solutionNeg}");
        }
    }
}
