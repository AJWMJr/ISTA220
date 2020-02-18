using System;

namespace Cssbs_Quiz5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[4];
            string testString = "Pokemon Sword and Shield";
            Console.WriteLine($"The test string is [{testString}]");
            myArray = testString.Split(" ");
            Console.WriteLine($"The length of my string is {myArray.Length}.");
            foreach (string e in reverse(myArray))
                Console.WriteLine(e);
            Console.ReadLine();
        }
        private static string[] reverse(string[] A)
        {
            int i, w= A.Length;
            string[] B = new string[A.Length];
            for (i = 0; i < A.Length; i++)
            {
                w--;
                B[i] = A[w];
            }
            return B;
        }
    }
}
