using System;

namespace CsharpEX02
{
    class Program
    {
        static void Main(string[] args)
        {
            // averageTenGrades();
            // avgGrades();
            avgGradesF();
        }
        private static void averageTenGrades()
        {
            int i, n;
            int x = 0;
            string a;
            Console.WriteLine("enter 10 grades");
            for (i = 1; i <= 10; i++)
            {
                Console.Write($"{i}: ");
                a = Console.ReadLine();
                n = int.Parse(a);
                x += n;
            }
            x /= 10;
            char grade = assignG(x);
            Console.Write($"the class average is: {x} which is a {grade}");
            Console.ReadLine();
        }
        private static void avgGrades()
        {
            int i, n;
            int x = 0;
            string a;
            Console.WriteLine("how many grades do you need to enter?");
            string num = Console.ReadLine();
            int numG = int.Parse(num);
            if (numG > 0 && numG < 100)
            {
                for (i = 1; i <= numG; i++)
                {
                    Console.Write($"{i}: ");
                    a = Console.ReadLine();
                    n = int.Parse(a);
                    x += n;
                }
                x /= numG;
                char grade = assignG(x);
                Console.Write($"the class average is: {x} which is a {grade}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("you must choose a number above 0 and below 100");
                avgGrades();
            }
        }
        private static void avgGradesF()
        {
            int i, n;
            int count = 0;
            int x = 0;
            string a;
            Console.WriteLine("enter grades (type 'quit' when done)");
            for (i = 1; i <= 100; i++)
            {
                Console.Write($"{i}: ");
                a = Console.ReadLine();
                if (a == "done")
                    goto l1;
                else
                {
                    count++;
                    n = int.Parse(a);
                    x += n;
                }
            }
        l1:
            x /= count;
            char grade = assignG(x);
            Console.Write($"the class average is: {x} which is a {grade}");
            Console.ReadLine();
        }
        private static char assignG(int x)
        {
            char grade;
            if (x > 89)
                grade = 'A';
            else if (x > 79)
                grade = 'B';
            else if (x > 69)
                grade = 'C';
            else if (x > 59)
                grade = 'D';
            else
                grade = 'F';
            return grade;
        }
    }
}
