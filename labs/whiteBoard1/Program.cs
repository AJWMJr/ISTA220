using System;

namespace whiteBoard1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("count number of repeating characters");
            myFunction(0, 1, 2, 2, 3, 4, 5, 6, 7, 8, 8, 8, 3, 4, 9, 2);
        }

        private static void myFunction(params int[] A)
        {
            int i, h, count = 0, high = 0, win = 0;
            int len = A.Length;
            int[] container = new int[len];
            for (i = 0; i < len; i++)
            {
                for (h = 0; h < len; h++)
                {
                    if (A[i] == A[h])
                    {
                        count++;
                    }
                }
                if (high < count)
                {
                    high = count;
                    win = A[i];
                }
                count = 0;
            }
            Console.WriteLine($"{win} occurs {high} times");
        }
    }
}
