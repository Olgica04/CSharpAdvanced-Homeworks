﻿using Task2.Domain.Models;

Rectangle rectangle = new Rectangle(10, 5);
Console.WriteLine($"The area of rectangle is: {rectangle.GetArea()}");

Triangle triangle = new Triangle(4, 8);
Console.WriteLine($"The area of tirangle is: {triangle.GetArea()}");

Circle circle = new Circle(4);
Console.WriteLine($"The area of circle is: {circle.GetArea()}");