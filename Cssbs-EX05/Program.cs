using System;

namespace Cssbs_EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Console.WriteLine(AverageArray(A));
            Console.WriteLine(AverageArray(B));
            Console.WriteLine(AverageArray(C));
            printArray(reverse(A));
            printArray(reverse(B));
            printArray(reverse(C));
            rotate("left", 2, A);
            rotate("right", 2, B);
            rotate("left", 4, C);
            printArray(Sort(A));
        }
        private static double AverageArray(int[] A)
        {
            int count = A.Length;
            int i;
            double w = 0;
            for (i = 0; i < count; i++)
            {
                w += A[i];
            }
            w /= count;
            return w;
        }
        private static void printArray(int[] A)
        {
            int i;
            for (i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();
        }
        private static void rotate(string dir, int rep, int[] A)
        {
            int i;
            if (dir == "left")
            {
                for (i = 1; i <= rep; i++)
                    A = rotateL(A);
            }
            else if (dir == "right")
            {
                for (i = 0; i <= rep; i++)
                    A = rotateR(A);
            }
            else 
                Console.WriteLine("try again");
            printArray(A);
        }
        private static int[] reverse(int[] A)
        {
            var b = new int[A.Length];
            int i, w = A.Length;
            for (i = 0; i < A.Length; i++)
            {
                w--;
                b[i] = A[w];
            }
            return b;
        }
        private static int[] rotateR(int[] A)
        {
            int i;
            int[] b = new int[A.Length];
            for (i = 0; i < A.Length; i++)
            {
                if (i == (A.Length - 1))
                {
                    b[0] = A[i];
                }
                else
                {
                    b[i + 1] = A[i];
                }
            }
            return b;
        }
        private static int[] rotateL(int[] A)
        {
            int i, b = A[0];
            for (i = 0; i < A.Length - 1; i++)
                A[i] = A[i+1];
            A[i] = b;
            return A;
        }
        private static int[] Sort(int[] A)
        {
            int i;
            int[] B = new int[A.Length];
            for (i=0;i<A.Length;i++)
            {
                if (A[i] > A[i + 1])
                    B[i + 1] = A[i];
                else if (A[i] < A[i+1])
                    B[i] = A[i];
                else
                    B[i] = A[i];
            }
            return B;
        }
    }
}
