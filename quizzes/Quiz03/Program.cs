using System;
using System.Runtime.Serialization;

namespace Quiz03
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopingRecip();
        }

        private static void LoopingRecip()
        {
            Console.Write("Enter a positive integer to find its reciprocal: ");
            string num = Console.ReadLine();
            try
            {
                if (float.Parse(num) == 0)
                {
                    throw new System.DivideByZeroException("0 is not a valid integer");
                }
                else if (float.Parse(num) < 0)
                {
                    throw new System.DivideByNegativeException("Can not use a negative integer");
                }
                else
                {
                    float r = float.Parse(num);
                    float answer = reciprocal(r);
                    Console.WriteLine($"The reciprocal is {answer}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("you must enter an integer");
                LoopingRecip();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 is not a valid integer");
                LoopingRecip();
            }
            catch (DivideByNegativeException)
            {
                Console.WriteLine("The integer must be positive");
                LoopingRecip();
            }
        }

        static float reciprocal(float r)
        {
            float answer = 1 / r;
            return answer;
        }
    }
}

namespace System
{
    [Serializable]
    class DivideByNegativeException : Exception
    {
        public DivideByNegativeException()
        {
        }

        public DivideByNegativeException(string message) : base(message)
        {
        }

        public DivideByNegativeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DivideByNegativeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}