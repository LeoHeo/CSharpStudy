using System;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            const double r = 3.0;
            const double h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);

            Console.WriteLine($"Area of Circle = {c.Area():F2}");
            Console.WriteLine($"Area of Sphere = {s.Area():F2}");
            Console.WriteLine($"Area of Cylinder = {l.Area():F2}");
        }
    }
}
