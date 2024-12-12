using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_prac
{
    internal class Program
    {
        enum Day { sun=1, mon, tue=11, wed, thu, fri }; //by defalut index start with 0
        static void Main(string[] args)
        {
            Console.WriteLine(Day.sun); // sun
            int y = (int)Day.tue; // 11 ; Day.tue = tue;
            Console.WriteLine(y);
            int x = (int) Day.wed; // 12
            Console.WriteLine(x);
            Day favouriteDay = (Day)2; // mon
            Console.WriteLine($"Favourite day is: {favouriteDay}");
            Console.WriteLine((int)favouriteDay); // 2
            Console.WriteLine((Day)2); // mon
            //Console.WriteLine(Day.sun);
        }
            
        
    }
}
