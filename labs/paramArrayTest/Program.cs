using System;

namespace paramArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling ordinary array");
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum1 = Method1(myArray);
            Console.WriteLine($"sum1 is {sum1}");

            Console.WriteLine("calling parameter array");
            double sum = Method2(11, 12, 13, 14, 15, 16, 17, 18, 19);
            Console.WriteLine($"the average is {sum}");
        }
        private static double Method2(params int[] A)
        {
            double sum = 0;
            int len = A.Length;
            int holder;
            int i, h;
            for (i = 0; i < len; i++)
            {
                for (h = 0; h < len; h++)
                {
                    if (A[h] > A[i])
                    {
                        holder = A[i];
                        A[i] = A[h];
                        A[h] = holder;
                    }
                }
            }
            foreach (int s in A)
                sum += s;
            sum /= len;
            return sum;
        }
        private static int Method1(int[] myArray)
        {
            int sum = 0;
            foreach (int i in myArray)
                sum += i;
            return sum;
        }
    }
}
