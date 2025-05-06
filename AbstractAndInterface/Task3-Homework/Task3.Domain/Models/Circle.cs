
namespace Task3.Domain.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public const double Pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Pi * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Pi * Radius;
        }
    }
}
