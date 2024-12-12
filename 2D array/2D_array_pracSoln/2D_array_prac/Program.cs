using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array_prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 2] { { 11,22 },{ 33,44 },{ 55,66 } };
            Console.WriteLine(arr[2,1]);
            Console.WriteLine(arr.Length);
        }
    }
}
