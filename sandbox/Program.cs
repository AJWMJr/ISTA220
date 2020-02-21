using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            /* l1:
                Console.WriteLine("Please type a word");
                string Input = Console.ReadLine();
                bool space = Input.Contains(" ");
                if (space)
                {
                    Console.WriteLine("please enter only a single word");
                    goto l1;
                }
                char[] letters = Input.ToCharArray();
                Console.WriteLine($"your word contains {letters.Length}  letters");
                Console.WriteLine("The letters in order are: ");
                letters = sort(letters);
                foreach (char s in letters)
                {
                    Console.Write(s);
                    Console.Write(", ");
                }
            */
            int[] array1 = { 1, 3, 4, 6, 8, 8, 9 };
            int[] array2 = { 1, 2, 5, 6, 7, 11, 12, 132 };
            Merge(array1, array2);
        }

        private static void Merge(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length + array2.Length];
            int i = 0, w = 0;
            do
            {
                if (i < array1.Length)
                {
                    newArray[w] = array1[i];
                    w++;
                }
                if (i < array2.Length)
                {
                    newArray[w] = array2[i];
                    w++;
                }
                i++;
            }
            while (w < newArray.Length);
            sortArray(newArray);
        }

        private static void sortArray(int[] A)
        {
            int len = A.Length;
            for (int j = 0; j < len - 1; j++)
            {
                for (int i = 0; i < len - 1; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i + 1];
                        A[i + 1] = A[i];
                        A[i] = temp;
                    }
                }
            }
            foreach (int i in A)
                Console.WriteLine(i);
        }

        static char[] sort(char[] A)
        {
            int len = A.Length;
            char holder;
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
            return A;
        }

    }
}
