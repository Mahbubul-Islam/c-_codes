using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        /*public static void print() // static methods can call without any object creation
        {
            Console.WriteLine("This is print call!!");
        }

        public static int add(int x, int y) 
        {
            return x + y;
        }

        public static void StartSurvice(int upTime, bool shutDownAutometically)
        {
            Console.WriteLine($"The mechine will run upto {upTime}hrs and shutdown state is {shutDownAutometically}");
        }*/

        /*public static void Updated_value(ref int x) //ref works like pointer
        {
            x = 10;
        }*/
        /*public static int[] StudentMarks(int x, int y, int z)
        {
            x = 44;
            y = 65;
            z = 54;
            
            int[] scores = {x,y,z};
            return scores;
        }*/

        /*public static void calculation(int a, int b, out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
        }*/

        /*public static double TotalPrice(int price,double discount=0) // discount is optional parameret
        {
            double total = price - (price*discount / 100);
            return total;
        }*/

        /*public static void Status(string message,bool power ,string info="shut down") // named parameter with optional perameter
        { 
            Console.WriteLine($"{message}, Power status: {power}, Info: {info}");
        }*/

        static void Main(string[] args)
        {
            /*print();

            int a = add(1, 2);
            Console.WriteLine(a);

            var upTime = 3; // var datatype will automatically identify the data type
            var shutDownAutometically = false;
            StartSurvice(upTime, shutDownAutometically);*/

            /*int mathMark = 90;
            int phyMark = 88;
            int chemMark = 78;

            
            foreach (int i in StudentMarks(mathMark, phyMark, chemMark))
            {
                System.Console.WriteLine(i);
            }*/

            /*int orginal_number = 5;
            Console.WriteLine($"Before: {orginal_number}");
            Updated_value(ref orginal_number);
            Console.WriteLine($"After: {orginal_number}");*/


            /*int x = 4, y = 5;
            int sum, mul;
            calculation(x, y, out sum, out mul);
            Console.WriteLine(sum + " " + mul);*/

            /*int price=350;

            Console.WriteLine($"No discount!! total price: {TotalPrice(price)}tk");

            Console.WriteLine($"10% discount!! Total price: {TotalPrice(price, 10)}tk");*/



            /*Status(message: "Welome!! Hp-202 user", power: false); //name perameter called without optional perameter

            Status(power: true, info: "On", message: "Welcome!! HP-909 user"); // name perameter called with optional perameter*/


            


        }
    }
}
