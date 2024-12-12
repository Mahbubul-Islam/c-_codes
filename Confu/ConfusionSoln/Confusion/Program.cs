using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confusion
{
    public class Person
    {
        public Person(string name) { Console.WriteLine("Parent cons called!"); }
        public void display()
        {
            Console.WriteLine("This is person class display method.");
        }
    }
    public class Student: Person
    {
        
        public Student(string name):base(name) { Console.WriteLine("Child cons called!"); }
        public void print()
        {
            Console.WriteLine("This is person class print method.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person c = new Student("Shiam");
            //c.display();
            //c.print();

            //Console.WriteLine(c);
        }
    }
}
