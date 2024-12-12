using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            arr[0] = new int[] {34,54,33,23,56,99,34,12}; // define row size
            arr[1] = new int[5];
            //arr[0][3] = 45;
            arr[0][0] = 10;
            Console.WriteLine(arr[0][3]);
            Console.WriteLine(arr[0][0]); 
            Console.WriteLine(arr.Length); // length of the array is 5
            Console.WriteLine(arr[0].Length); // 8

            //int[] arr = new int[1] {1};
            //arr[0] = 45;
            //Console.WriteLine(arr[0]);
        }
    }
}
