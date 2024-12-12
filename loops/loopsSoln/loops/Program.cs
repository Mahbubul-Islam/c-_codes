using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //for loop
            /*for (; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/

            // while loop
            /*while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }*/

            // do while loop
            /*do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);*/

            // foreach loop

            int[] arr = { 55, 34, 43, 51,12,67,65,30 };
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
