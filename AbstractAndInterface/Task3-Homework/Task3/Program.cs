using Task3.Domain.Models;

Circle circle = new Circle(14);
Console.WriteLine($"The area of circle is: {circle.CalculateArea()}");
Console.WriteLine($"The perimeter of circle is: {circle.CalculatePerimeter()}");

Triangle triangle = new Triangle(3,4,5);
Console.WriteLine($"The perimeter of triangle is: {triangle.CalculatePerimeter()}");
Console.WriteLine($"The area of triangle is: {triangle.CalculateArea()}");

