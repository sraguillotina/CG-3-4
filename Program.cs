using System;

namespace Class3_Assignment4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a calculator taking two numbers in-put by the user.
            Console.WriteLine("Pick two numbers and decide if you'd like to add, subtract, or divide them.");
            
            Console.WriteLine();
            //Variable firstNumber is parsed as integer x. 
            Console.Write("Enter your first number: ");
            string firstNumber = Console.ReadLine();
            int x = int.Parse(firstNumber);
        
            //Variable secondNumber is parsed as integer y.
            Console.Write("Enter your second number: ");
            string secondNumber = Console.ReadLine();
            int y = int.Parse(secondNumber);

         
            Console.Write("Choose a math operation to conduct: add, subtract, multiply, or divide: ");
            /*Variable operation is the user's chosen mathematical operation to be performed with the
            firstNumber and secondNumber values*/
            string operation = Console.ReadLine();

            /*Conditionals using if, else if, and else are used to determine which mathematical
             operation to execute as per user's input.*/
            //first conditional evaluates if the user requested addition.
            if (operation == "add")
            {
                int a = x + y;
               //integer value a is the result of the performed addition.
                Console.WriteLine($"Your result is {a}.");
            }
            //second conditional evaluates if the user requested subtraction.
            else if (operation == "subtract")
            {
                int b = x - y;
                //integer value b is result of the performed subtraction.
                Console.WriteLine($"Your result is {b}.");
            }
            //third conditional evaluates if the user requested multiplication.
            else if (operation == "multiply")
            { int c = x * y;
                //integer variable c is result of the performed multiplication.
                Console.WriteLine($"Your result is {c}.");
            }
            //fourth conditional evaluates if the user requested division.
            else if (operation == "divide")
            { int d = x / y;
               //integer variable d is the result of the performed division.
                Console.WriteLine($"Your result is {d}.");
            } 
            //else conditional used as a catch-all for math operations outside parameters.
            else
            {
                string errorMessage = "Sorry, the operation you entered is invalid.";
                Console.WriteLine(errorMessage); }
            Console.ReadLine();




        }
    }
}
