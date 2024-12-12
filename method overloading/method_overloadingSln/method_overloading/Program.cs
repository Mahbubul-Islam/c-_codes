using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    internal class Program
    {
        public static void Display()
        {
            Console.WriteLine("This is Display function without perameter.");
        }
        public static void Display(int a)
        {
            Console.WriteLine("This is Display function with perameter: "+a);
        }

        public static void Display(int a, int b)
        {
            Console.WriteLine("This is Display function with perameter: " + a+", "+b);
        }
        public static void Display(string b)
        {
            Console.WriteLine("This is Display function with perameter: "+b);
        }

        static void Main(string[] args)
        {
            Display();
            Display(22);
            Display(1,2);
            Display("Congratulations!!!");
        }
    }
}
