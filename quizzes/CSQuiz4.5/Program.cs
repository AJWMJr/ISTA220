using System;

namespace CSQuiz4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            talk();
        }
        private static void talk()
        {
            Console.Write("Please enter a number(escape value is 1): ");
            string endS = Console.ReadLine();
            if (double.Parse(endS) == 1)
            {
                return;
            }
            else
            {
                double end = double.Parse(endS);
                addSqrRt(ref end);
                Console.WriteLine($"the sum of the square roots is: {end}");
                talk();
            }
        }
        private static double addSqrRt(ref double end)
        {
            double i;
            double a = 0;
            for (i=0;i<=end;i++)
            {
                a += Math.Sqrt(i);
            }
            end = a;
            return end;
        }
    }
}
