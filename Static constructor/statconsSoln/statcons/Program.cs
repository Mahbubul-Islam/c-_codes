using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statcons
{
   
    public class A
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private static int y;
        public static int Y
        {
            get { return y; }
            set { y = value; }
        }
        public A() 
        {
            X = 0;
            Console.WriteLine("Default cons called!");
        }
        public A(int x1)
        {
            this.X = x1;
            Console.WriteLine("Perameterized cons called!");
            Console.WriteLine($"The value of x is: {X}");
        }
        static A() // static constructor
        {
            Y = 10;
            Console.WriteLine("Static cons called!");
        }
        public A(A obj) // copy construtor
        {
            this.X = obj.X;
        }
    }
    internal class Program
    {
        readonly int a; //readonly variable
        public Program()
        {
            a = 10; // only can assign in constructor
        }
        static void Main(string[] args)
        {
            A obj1 = new A();
            A obj2 = new A(20);
            A obj3 = new A(obj1);
            A obj4 = new A(obj2);
            Program p = new Program();
            Console.WriteLine(p.a);
        }
    }
}
