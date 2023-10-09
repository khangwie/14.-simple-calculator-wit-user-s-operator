using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.simple_calculator_wit_user_s_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name ");
            Double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter an operator");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number");
            Double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
                Console.WriteLine(num1 / num2);
            {
                Console.WriteLine("Not an operator");
            }
            Console.Read();


        }
    }
}
           
            