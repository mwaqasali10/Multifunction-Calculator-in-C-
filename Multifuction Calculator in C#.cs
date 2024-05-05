// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multifunction Calculator");
            Console.WriteLine("Choose your Calculator Type" + "\n" + "1.Normal Calculator" + "\n" + "2.Scientific Calculator");
            string conform;
            int Choice;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Choice) && (Choice == 1 || Choice == 2))
                {
                    break;
                }
                Console.WriteLine("Invalid Choic Please Enter 1 or 2 ");
            }
            if (Choice == 1)
            {
                NormalCalculator();
            }
            else if(Choice ==2)
            {
                ScientificCalculator();
            }
            else
            {
                Console.WriteLine("Please enter a valid input to select calculator type.");
            }
            Console.WriteLine("Would you like to perform another operation? (yes/no): yes");
            conform = Console.ReadLine().ToLower();
            while (conform == "yes") ;
            Console.WriteLine("Thank you for your Coming.");

        }

        static void NormalCalculator()
        {
            double num1;
            double num2;

            Console.WriteLine("You have selected the Normal Calculator.");
            Console.WriteLine("Available Operations:");
            Console.WriteLine("1. Addition (+)\n2. Subtraction (-)\n3. Multiplication (*)\n4. Division (/)");
            Console.WriteLine("Enter the number for the operation you want to perform: ");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("You have selected Addition.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Addition of two numbers = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine("You have selected Subtraction.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Subtraction of two numbers = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine("You have selected Multiplication.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Multiplication of two numbers = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine("You have selected Division.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Division of two numbers = {num1 / num2}");
                    }
                    break;

            }
        }
        static void ScientificCalculator()
        {
            double num1;
            double num2;
            
            Console.WriteLine("You have selected the Scientific Calculator.");
            Console.WriteLine("Available Operations:");
            Console.WriteLine("1. Addition (+)\n2. Subtraction (-)\n3. Multiplication (*)\n4. Division (/)\n5. Power (x^y)\n6. Square Root (√x)\n7. Logarithm (log)\n8. Sine (sin)\n9. Cosine (cos)\n10. Tangent (tan)");
            Console.WriteLine("Enter the number for the operation you want to perform: ");
            int operation = int.Parse(Console.ReadLine());


            switch (operation)
            {
                case 1:
                    Console.WriteLine("You have selected Addition.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Addition of two numbers = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine("You have selected Subtraction.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Subtraction of two numbers = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine("You have selected Multiplication.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Multiplication of two numbers = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine("You have selected Division.");
                    Console.WriteLine("Enter a first number");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"Division of two numbers = {num1 / num2}");
                    }
                    break;

                case 5:
                    Console.WriteLine("You have selected Power.");
                    Console.WriteLine("Enter a base number.");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a power number.");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num1} raise to the power {num2} = {Math.Pow(num1, num2)}");
                    break;
                case 6:
                    Console.WriteLine("You have selected Square Root.");
                    Console.WriteLine("Enter a number to calculate square root.");
                    double squareRoot = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Square Root of {squareRoot} = {Math.Sqrt(squareRoot)}");
                    break;
                case 7:
                    Console.WriteLine("You have selected Logarithm.");
                    Console.WriteLine("Enter a number to calculate Log.");
                    double log = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Log of {log} = {Math.Log10(log)}");
                    break;
                case 8:
                    Console.WriteLine("You have selected Trignometric function Sine.");
                    Console.WriteLine("Enter a number to calculate value of Sine.");
                    double valSine = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Value of Sine({valSine}) in radians = {Math.Sin(valSine)})");
                    break;
                case 9:
                    Console.WriteLine("You have selected Trignometric function Cosine.");
                    Console.WriteLine("Enter a number to calculate value of Cosine.");
                    double valCosine = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Value of Cosine({valCosine}) in radians = {Math.Cos(valCosine)}");
                    break;
                case 10:
                    Console.WriteLine("You have selected Trignometric function Tangent.");
                    Console.WriteLine("Enter a number to calculate value of Tangent.");
                    double valTangent = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Value of Tangent({valTangent}) in radians = {Math.Tan(valTangent)}");
                    break;

                    



            };

        }
        }
    }
    


                   








