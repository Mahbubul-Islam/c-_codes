using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, res;
            char ch;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            y  = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an operational key: ");
            ch = Convert.ToChar(Console.ReadLine());

            //using if else

            /*if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
            {
                if (ch == '+')
                {
                    res = x + y;
                    Console.WriteLine($"{x} + {y} : {res}");
                }
                else if (ch == '-')
                {
                    res = x - y;
                    Console.WriteLine($"{x} - {y} : {res}");
                }
                else if (ch == '*')
                {
                    res = x * y;
                    Console.WriteLine($"{x} * {y} : {res}");
                }
                else
                {
                    res = x / y;
                    Console.WriteLine($"{x} / {y} : {res}");
                }
            }
            else
            {
                Console.WriteLine("Error!! Please give current operator");
            }*/

            //using switch case

            switch (ch)
            {
                case '+':
                    res = x+y;
                    Console.WriteLine($"{x} + {y} : {res}");
                    break;

                case '-':
                    res = x-y;
                    Console.WriteLine($"{x} - {y} : {res}");
                    break;

                case '*':
                    res = x*y;
                    Console.WriteLine($"{x} * {y} : {res}");
                    break;

                case '/':
                    res = x/y;
                    Console.WriteLine($"{x} / {y} : {res}");
                    break;

                default:
                    Console.WriteLine("Error!! Please give current operator"); 
                    break;

            }
        }
    }
}
