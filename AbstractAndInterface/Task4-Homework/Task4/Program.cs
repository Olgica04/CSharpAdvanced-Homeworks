
using Task4.Domain.Models;

Manager manager = new Manager(1, "Marko", 800, 078123456, "EmptyStreet","Marketing",150);
Console.WriteLine($"The salary of manager is: {manager.CalculateSalary()}");
manager.DisplayInfo();

List<string> languages = new List<string> { "C#", "Java", "Python" };
Programmer programmer = new Programmer(1, "Dejan", 750, 078111222, "DeStreet", languages, "ProjectX",100);
Console.WriteLine($"The salary of programmer is: {programmer.CalculateSalary()}");
programmer.DisplayInfo();

