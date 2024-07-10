using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            operators();

            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            bool control = true;

            if (choice == 0)
            {
                break;
            }

            switch (choice)
            {
                case 1:

                    result = num1 + num2;
                    break;

                case 2:

                    result = num1 - num2;
                    break;

                case 3:

                    result = num1 * num2;
                    break;

                case 4:

                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }

                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        control = false;
                    }

                    break;

                case 5:

                    result = Math.Sqrt(num1);
                    break;

                case 6:

                    result = Math.Pow(num1, num2);
                    break;

                case 7:

                    result = Math.Sin(num1);
                    break;

                case 8:

                    result = Math.Cos(num1);
                    break;

                case 9:

                    result = Math.Tan(num1);
                    break;


                default:

                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    control = false;
                    break;

            }



            Console.WriteLine(" ");
            Console.WriteLine("**************************");
            Console.WriteLine(" ");
            Console.WriteLine("Your result: " + result);
            Console.WriteLine(" ");
            Console.WriteLine("**************************");
            Console.WriteLine(" ");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }

    static void operators()

    {
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Square Root");
        Console.WriteLine("6 - Power");
        Console.WriteLine("7 - Sine");
        Console.WriteLine("8 - Cosine");
        Console.WriteLine("9 - Tangent");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("");
        Console.Write("Select an operation: ");
    }
}
}
