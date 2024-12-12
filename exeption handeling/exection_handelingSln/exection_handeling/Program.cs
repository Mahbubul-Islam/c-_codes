using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exection_handeling
{
    internal class Program
    {
        public static int cal(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a denumerator: ");
                int denumerator = Convert.ToInt32(Console.ReadLine());

                int result = cal(numerator, denumerator);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Can not divide by 0!");
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Error: Invalid input format. Please enter a number.");
            }
            finally
            {
                Console.WriteLine("Thank you for using the calculator.");
            }
        }
    }
}
