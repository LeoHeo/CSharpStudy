using System;

namespace Virtual
{
    /**
     * 상속을 받았을때 메소드 override 하기 위해서는 
     * 부모메소드가 virtual
     * 자식메소드는 override
     */

    public class Shape
    {
        public const double Pi = Math.PI;
        protected double X, Y;

        public Shape()
        {
            
        }

        public Shape(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual double Area()
        {
            return X * Y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return Pi * X * X;
        }
    }

    class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * Pi * X * X;
        }
    }

    class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * Pi * X * X + 2 * Pi * X * Y;
        }
    }
}