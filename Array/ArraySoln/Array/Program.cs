using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //jagged array

            int[][] arr = new int[3][]; //explicite
            arr[0] = new int[3] { 34, 32, 21 };
            arr[1] = new int[5] { 56, 52, 36, 65, 17 };
            arr[2] = new int[3] { 99, 66, 69 };

            //int[][] arr = new int[][] //implicite
            //{
            //    new int[] { 34, 32, 21 },
            //    new int[] { 56, 52, 36, 65, 17 },
            //    new int[] { 99, 66, 69 }
            //};



            //Console.WriteLine(arr[0][2]); // output: 21
            //Console.WriteLine(arr[1][2]); // output: 36


            for(int i = 0; i< arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+ " ");
                }
                Console.WriteLine();
            }


            /*int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //for(int i = 0; i < 2; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"The element of row {i} and column {j} is: {arr[i, j]}");
                }
                
            }*/

            /*int[] arr1 = new int[4] { 1, 2, 3, 4 };
            //int[] arr = { 1, 2, 3, 4 };
            for (int i = 0; i < arr1.Length; i++) 
            { 
                Console.Write(arr1[i]+" ");
            }*/
        }
    }
}
