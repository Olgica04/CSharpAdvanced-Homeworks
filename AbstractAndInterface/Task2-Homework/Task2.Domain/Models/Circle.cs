using Task2.Domain.Interface;

namespace Task2.Domain.Models
{
    public class Circle : IShape
    {
        public const double Pi = 3.14; public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }


}