using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPrac
{
    public struct Student
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private int noc;
        public int Noc
        {
            get { return noc; }
            set { noc = value; }
        }

        public Student(string name, string id, int age, float cgpa, int noc)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.cgpa = cgpa;
            this.noc = noc;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mahbubul Islam", "22-49929-3", 22, 3.55f, 101);
            Console.WriteLine($"Name: {s1.Name}\nId: {s1.Id}\nAge: {s1.Age}\nCgpa: {s1.Cgpa}\nNoc: {s1.Noc}");
        }

    }  
}

