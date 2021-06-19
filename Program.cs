using System;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        void Run()
        {
            
            try
            {
                Console.Write("Enter a number: ");
                string num1 = Console.ReadLine();
                Console.Write("Enter an operator (+,-,/,*): ");
                string operatorValue = Console.ReadLine();
                Console.Write("Enter another number: ");
                string num2 = Console.ReadLine();
                Console.WriteLine($"Result is: {CalculateValues(num1, operatorValue, num2)}");
                ToContinue();
            }
            catch (FormatException)
            {
                 
                Console.WriteLine("Invalid input, please try again");
                Run();
            }

        }

        string CalculateValues(string num1, string o, string num2)
        {   
            //Convert string valuess into double values
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            double totalValue = 0;
            switch (o)
            {
                case "+":
                    {
                        totalValue = Addition(n1, n2);
                        break;
                    }
                case "-":
                    {
                        totalValue = Subtraction(n1, n2);
                        break;
                    }
                case "*":
                    {
                        totalValue = Multiplication(n1, n2);
                        break;
                    }
                case "/":
                    {
                        totalValue = Division(n1, n2);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid operator, please try again");
                    Run();
                    break;
            }
            return totalValue.ToString();
        }



        double Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        double Division(double num1, double num2)
        {
            double result = 0;
            if(num2 == 0)
            {
                Console.WriteLine("Error, cannot divide by 0. Try again.");
                Run();
            }
            else
            {
               result = num1 / num2;
            }            
            return result;
        }

        void ToContinue()
        {
            Console.WriteLine("Input 'n' to exit. Otherwise, press 'Enter'.");
            string keepGoing = Console.ReadLine();
            if(keepGoing == "n")
            {
                //Terminates the program
                Environment.Exit(1);
            }
            else
            {
                Run();
            }

        }
    }
}
