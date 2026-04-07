using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class classLab2
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");

        float num1 = Convert.ToSingle(Console.ReadLine());


        Console.Write("Please enter the Second number: ");

        float num2 = Convert.ToSingle(Console.ReadLine());


        Console.Write("Please enter the operator (+, -, *, /): ");

        char op = Convert.ToChar(Console.ReadLine());


        if (op == '+')
        {
            Console.WriteLine("Result after summation: " + (num1 + num2));

        }
        else if (op == '-')
        {
            Console.WriteLine("Result after subtraction: " + (num1 - num2));

        }
        else if (op == '*')
        {
            Console.WriteLine("Result after multiplication: " + (num1 * num2));

        }
        else if (op == '/')
        {
            if (num2 != 0)
            {
                Console.WriteLine("Result after division: " + (num1 / num2));

            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");

            }
        }
        else
        {
            Console.WriteLine("Invalid operator. Please enter the correct operator");

        }
    }
}
