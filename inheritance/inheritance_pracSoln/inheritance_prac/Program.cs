using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_prac
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal class constructor called.");
        }
        public void Move()
        {
            Console.WriteLine("I am moving.");
        }
    }
    public class Cat:Animal
    {
        public Cat():base()
        {
            Console.WriteLine("Cat class constructor called.");
        }
        public void Climb()
        {
            Console.WriteLine("I am climbing.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.Move();
            c1.Climb();
        }
    }
}
