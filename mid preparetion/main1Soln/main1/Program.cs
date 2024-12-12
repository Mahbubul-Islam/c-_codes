using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double d = 98; // works with d and without d
            //Console.WriteLine(d);
            //float f = 3.33f; // only works with both f and F in the last
            //Console.WriteLine(f);
            //long b = 456; // only works with L in the last
            //Console.WriteLine(b);

            int i, j = 1, k;
            for (i = 0; i < 5; i++)
            {
                k = j++ + ++j;
                Console.WriteLine(k+" ");
            }

        }
    }
}
