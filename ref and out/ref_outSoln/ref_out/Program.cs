using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out
{
    internal class Program
    {
        public static int ref_result(ref int a, ref int b, int c)
        {
            int x = a + b + c;
            return x;
        }
        public static int out_result(out int a, out int b, out int c)
        {
            a = 10;
            b = 30;
            c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            int a = 40; // ref needs to assign value
            int b = 30;
            int x, y, z; // out doesn't need to assign value

            Console.WriteLine(ref_result(ref a, ref b, 30));
            Console.WriteLine(out_result(out x, out y, out z));
        }
    }
}
