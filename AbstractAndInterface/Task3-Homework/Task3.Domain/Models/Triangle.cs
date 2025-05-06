using System;

namespace Task3.Domain.Models
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double CalculatePerimeter()
        {
            return A + B + C;
        }
        public override double CalculateArea()
        {
            double area = CalculatePerimeter() / 2; 
            return Math.Sqrt(area * (area - A) * (area - B) * (area - C));
        }

        
    }
}
