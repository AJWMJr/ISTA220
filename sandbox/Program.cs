using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
        l1:
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
