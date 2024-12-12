using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace run_time_ploymorphism_prac
{
    public class Shape
    {
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Shape()
        {
            this.Height = 0;
            this.Width = 0;
        }
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public virtual double Area()
        {
            return 0;
        }
        public virtual void Display()
        {
            Console.WriteLine("This will display the area.");
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle() { }
        public Rectangle(double height, double width):base(height, width)
        {

        }
        public override double Area() 
        {
            return Height * Width;
        }
        public override void Display() 
        {
            Console.WriteLine("For Rectangle");
            Console.WriteLine($"Height: {Height}\nWidth: {Width}\nArea: {Area()}");
            Console.WriteLine();
        }
    }
    public class Triangle : Shape
    {
        public Triangle() { }
        public Triangle(double height, double width) : base(height, width)
        {

        }
        public override double Area()
        {
            return 0.5*Height * Width;
        }
        public override void Display()
        {
            Console.WriteLine("For Triange");
            Console.WriteLine($"Height: {Height}\nWidth: {Width}\nArea: {Area()}");
            Console.WriteLine();
        }
    }
    public class Circle : Shape 
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 3.1416 * Radius * Radius;
        }
        public override void Display()
        {
            Console.WriteLine("For Circle");
            Console.WriteLine($"Radius: {Radius}\nArea: {Area()}");
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10,20);
            Shape triangle = new Rectangle(10,15);
            Shape circle = new Circle(5);

            rectangle.Display();
            triangle.Display();
            circle.Display();
        }
    }
}
