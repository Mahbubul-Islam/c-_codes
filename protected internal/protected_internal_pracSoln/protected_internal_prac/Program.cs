using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace protected_internal_prac
{
    public class A
    {
        protected internal int x;
        public A() { }
        public A(int x) { this.x = x; }
        public virtual void display()
        {
            
        }
    }
    public class C:A
    {
        public C() { }
        public C(int x):base(x) { this.x = x; }
        public override void display() 
        {
            Console.WriteLine(x);
        }
    }
    public class D : C
    {
        public D() { }
        public D(int x) : base(x) { this.x = x; }
        public override void display() { Console.WriteLine(x); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            obj1.x = 45;
            obj1.display();

            D obj2 = new D();
            obj2.x = 10;
            obj2.display();
        }
    }
}
