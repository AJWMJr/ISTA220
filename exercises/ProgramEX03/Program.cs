using System;
using System.Runtime.Serialization;

namespace ProgramEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        private static void start()
        {
            Console.WriteLine("Area and Circumference of a Circle");
            Console.Write("enter a number for radius: ");
            try
            {
                string radius = Console.ReadLine();
                if (int.Parse(radius) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else
                {
                    int intRadius = int.Parse(radius);
                    double circum = 2 * Math.PI * intRadius;
                    Console.WriteLine($"The Circumference is {circum}");
                    circleArea(intRadius);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("please use a valid integer");
                start();
            }
            catch (NegativeIntegerException)
            {
                Console.WriteLine("please us a valid integer");
                start();
            }
        }

        private static void circleArea(int intRadius)
        {
            double area = Math.PI * intRadius * intRadius;
            Console.WriteLine($"The Area is {area}");
            volume();
        }

        private static void volume()
        {
            Console.WriteLine("Volume of a hemisphere");
            Console.Write("enter a number for radius: ");
            string radius = Console.ReadLine();
            try
            {
                if (int.Parse(radius) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else
                {
                    int intRadius = int.Parse(radius);
                    double volume = (1.33333333 * Math.PI * intRadius * intRadius * intRadius) / 2;
                    Console.WriteLine($"The Volume of this Hemisphere is {volume}");
                    triangleArea();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("please use a valid integer");
                volume();
            }
            catch (NegativeIntegerException)
            {
                Console.WriteLine("please us a valid integer");
                volume();
            }
        }

        private static void triangleArea()
        {
            Console.WriteLine("Area of a Triangle");
            Console.WriteLine("enter values for the three sides");
            Console.Write("Side A: ");
            string sA = Console.ReadLine();
            Console.Write("Side B: ");
            string sB = Console.ReadLine();
            Console.Write("Side C: ");
            string sC = Console.ReadLine();
            try
            {
                if (int.Parse(sA) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else if (int.Parse(sB) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else if (int.Parse(sC) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else
                {
                    int intSA = int.Parse(sA);
                    int intSB = int.Parse(sB);
                    int intSC = int.Parse(sC);
                    double perim = (intSA + intSB + intSC) / 2;
                    double area = Math.Sqrt(perim * (perim - intSA) * (perim - intSB) * (perim - intSC));
                    Console.WriteLine($"The area is {area}");
                    quad();
                }
            }
            catch (NegativeIntegerException)
            {
                Console.WriteLine("please enter valid integers");
                triangleArea();
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter valid integers");
                triangleArea();
            }
        }

        private static void quad()
        {
            Console.WriteLine("The quadratic equation");
            Console.WriteLine("Enter the coefficients");
            Console.Write("X: ");
            string first = Console.ReadLine();
            Console.Write("Y: ");
            string second = Console.ReadLine();
            Console.Write("Z: ");
            string third = Console.ReadLine();
            try
            {
                if (int.Parse(first) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else if (int.Parse(second) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else if (int.Parse(third) <= 0)
                {
                    throw new NegativeIntegerException();
                }
                else
                {
                    int intF = int.Parse(first);
                    int intS = int.Parse(second);
                    int intT = int.Parse(third);
                    int intA = 2 * intF;
                    double solutionPos = (-1 * intS) + Math.Sqrt((intS * intS) - (4 * intF * intT)) / (2 * intA);
                    double solutionNeg = (-1 * intS) - Math.Sqrt((intS * intS) - (4 * intF * intT)) / (2 * intA);
                    Console.WriteLine($"The positive solution is {solutionPos}");
                    Console.WriteLine($"The negative solution is {solutionNeg}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter a valid integer");
                quad();
            }
            catch (NegativeIntegerException)
            {
                Console.WriteLine("please enter a valid integer");
                quad();
            }
        }
    }
}

[Serializable]
internal class NegativeIntegerException : Exception
{
    public NegativeIntegerException()
    {
    }

    public NegativeIntegerException(string message) : base(message)
    {
    }

    public NegativeIntegerException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected NegativeIntegerException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

