using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {

        public static int[] StudentMarks(int x, int y, int z)
        {
            x = 44;
            y = 65;
            z = 54;

            int[] scores = { x, y, z };
            return scores;
        }

        static void Main(string[] args)
        {
          
            int mathMark = 90;
            int phyMark = 88;
            int chemMark = 78;


            foreach (int i in StudentMarks(mathMark, phyMark, chemMark))
            {
                System.Console.WriteLine(i);
            }



        }
    }
}
