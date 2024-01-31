using System;

namespace ShapesExample
{
    class Shape
    {
        private string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return "Color: " + color;
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius, string color) : base(color)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return base.ToString() + ", Radius: " + radius + ", Area: " + getArea();
        }
    }

    class Cylinder : Circle
    {
        private double height;

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            return getArea() * height;
        }

        public override string ToString()
        {
            return base.ToString() + ", Height: " + height + ", Volume: " + getVolume();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0, "Red");
            Cylinder cylinder = new Cylinder(3.0, "Blue", 10.0);

            Console.WriteLine("Circle: " + circle);
            Console.WriteLine("Cylinder: " + cylinder);
        }
    }
}
