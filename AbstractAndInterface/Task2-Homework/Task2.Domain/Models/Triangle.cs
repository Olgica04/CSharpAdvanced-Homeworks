using Task2.Domain.Interface;

namespace Task2.Domain.Models

{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
        public double GetArea()

        {
            return 0.5 * Base * Height;
        }
    }
}