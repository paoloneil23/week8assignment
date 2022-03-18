using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8assignment
{
    class Part1
    {
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("0) Exit");
        }

        static void Main(string[] args)
        {
            DisplayMenu();
            Console.ReadLine();
        }
    }

    class Part2
    {
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("0) Exit");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayMenu();
                Console.Write("enter menu number choice: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Calculate Sum");
                        break;
                    case 2:
                        Console.WriteLine("Calculate Sum of Squares");
                        break;
                    case 3:
                        Console.WriteLine("Calculate Sum of Cubes");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }

    class PartFinal
    {
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("4) Calculate Average");
            Console.WriteLine("5) Calculate and Display Equation");
            Console.WriteLine("0) Exit");
        }

        static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter a number to add: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            return sum;
        }

        static int CalculateSumOfSquares(int s)
        {
            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                Console.Write("enter a number to square: ");
                int numSquare = Convert.ToInt32(Console.ReadLine());
                sum += numSquare * numSquare;
            }
            return sum;
        }

        static int CalculateSumOfCube()
        {
            int sum = 0;
            Console.Write("enter amount of input you want to cube: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.Write("enter a number to cube: ");
                int numCube = Convert.ToInt32(Console.ReadLine());
                sum += numCube * numCube * numCube;

            }
            return sum;
        }

        static double CalculateAverage()
        {
            double sum = 0;
            double average;
            Console.Write("enter amount of input to average: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("enter a number: ");
                int numToAvg = Convert.ToInt32(Console.ReadLine());
                sum += numToAvg;
            }
            average = sum / num;
            Console.WriteLine(sum);
            return average;
        }

        static void DisplayEquation()
        {
            double x = 0;
            double y = 5;
            Console.WriteLine("   x        5        3x        -2x^2          y");
            Console.WriteLine("  ---      ---      ----      -------        ---");
            while (x <= 2)
            {
                double a = -2 * (x * x);
                double b = 3 * x;
                double c = -2 * (x * x) + 3 * x + 5;
                Console.WriteLine($"{x,5} {y,7} {b,10} {a,12} {c,10}");
                x += 0.25;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayMenu();
                Console.Write("Enter a number from 1-5: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Calculate Sum \n");
                        Console.WriteLine($"sum of all user input is {CalculateSum(5)}");
                        break;

                    case 2:
                        Console.WriteLine("Calculate Sum of Squares \n");
                        Console.Write("enter amount of input you want to square: ");
                        int amountOfInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"sum of all user input is {CalculateSumOfSquares(amountOfInput)}");
                        break;

                    case 3:
                        Console.WriteLine("Calculate Sum of Cubes \n");
                        Console.WriteLine($"sum of all user input is {CalculateSumOfCube()}");
                        break;

                    case 4:
                        Console.WriteLine("Calculate Average of input \n");
                        Console.WriteLine($"the average of all input is {CalculateAverage()}");
                        break;

                    case 5:
                        Console.WriteLine("Calculate and Display Equation \n");
                        DisplayEquation();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }

}
