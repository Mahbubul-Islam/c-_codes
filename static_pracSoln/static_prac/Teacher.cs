using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_prac
{
    public class Teacher
    {
        public static string t_address; // static variable must be declared with access modifier
        string t_name; //by default public
        private int t_id;

        public Teacher(string t_name, int t_id)
        {
            this.t_name = t_name;
            this.t_id = t_id;
            
        }
        public int T_id
        {
            get
            {
                return t_id;
            }
            set
            {
                t_id = value;
            }
        }

        public void t_info()
        {
            Console.WriteLine($"Teacher name is: {t_name}\nTeacher id is: {T_id}\nTeacher address: {t_address}");
        }
    }
}
