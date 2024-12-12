using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_prac
{
    public static class Student
    {
        private static int id; // the member of a static class must be static
        public static int Id
        {
            get 
            { 
                return id; 
            }
            set 
            {
                id = value;
            }
        }
        public static string name;

        //public Student(string id) // static class contructors must be parameterless
        //{
        //    this.id = id;
        //}
        static Student() // static class can have static constuctors
        {
            name = "";
            Id = 0;
        }
        

        public static void info(int Id, string name)
        {
            Console.WriteLine($"{name}'s id is: {Id}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //static class doesn't need to creat any object

            Student.name = "Mahbubul Islam"; // define a static variable
            Student.Id = 303;
            Student.info(Student.Id, Student.name); // call a static function

            Teacher t1 = new Teacher("Nayme", 303);
            Teacher.t_address = "Basundhara";
            t1.t_info();


        }
    }
}
