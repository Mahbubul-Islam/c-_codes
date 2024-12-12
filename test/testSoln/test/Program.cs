using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{


    public class Grandparent
    {
        public Grandparent()
        {
            Console.WriteLine("I am grandparent cons");
        }

        //public void DisplayGrandParentsAB()
        //{
        //    Console.WriteLine("A and B are my grandparents");
        //}
    }

    public class Parent : Grandparent
    {
        public Parent()
        {
            Console.WriteLine("I am parent cons");
            //public void DisplayParentsCD()
            //{
            //    Console.WriteLine("C and D are my parents");
            //}
        }

        public class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("I am child cons");
                //public void DisplayChildZ()
                //{
                //    Console.WriteLine("I am the child Z");
                //}
            }

            public class Program
            {
                public static void Main(string[] args)
                {
                    Child cd = new Child();
                    //cd.DisplayChildZ();
                    //cd.DisplayParentsCD();
                    //cd.DisplayGrandParentsAB();
                }
            }



            //public class Parent
            //{
            // public Parent() { Console.WriteLine("parent cons"); }
            //    //public void DisplayParentsAB()
            //    //{
            //    //    Console.WriteLine("A and B are my parents");
            //    //}
            //}

            //public class ChildC : Parent
            //{

            //public ChildC()
            //{
            //    Console.WriteLine("childC cons called");
            //}
            //    //public void DisplayChildC()
            //    //{
            //    //    Console.WriteLine("I am the child C");
            //    //}
            //}

            //public class ChildD : Parent
            //{
            //public ChildD()
            //{
            //    Console.WriteLine("I am the child D");
            //}
            //    //public void DisplayChildD()
            //    //{
            //    //    Console.WriteLine("I am the child D");
            //    //}
            //}

            //public class Program
            //{
            //    public static void Main(string[] args)
            //    {
            //        ChildC cc = new ChildC();
            //        ChildD cd = new ChildD();

            //    //cc.DisplayChildC();
            //    //cc.DisplayParentsAB(); // accessing parent class

            //    //cd.DisplayChildD();
            //    //cd.DisplayParentsAB(); // accessing parent class
            //}
            //}

        }
    }
}



