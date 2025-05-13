
using System.Xml.Linq;
using Task1.Domain;
using Task1.Domain.Models;


var user1 = UserDatabase.SearchById(2);

if (user1 != null)
{
    Console.WriteLine($"User with ID: {user1.Id} is {user1.Name}");
}
else
{
    Console.WriteLine("User not found");
}

List<User> userByName = UserDatabase.SearchByName("Ivan");
foreach ( User userName in userByName)
{
    Console.WriteLine($"Found user: {userName.Name}");
}

List<User> userByAge = UserDatabase.SearchByAge(39);
foreach (User userName in userByAge)
{
    Console.WriteLine($"Found user: {userName.Name} with age: {userName.Age}");
}


int id = 1;
string name = "Ivan";
int age = 25;

if (id <= 0 || string.IsNullOrWhiteSpace(name) || age <= 0)
{
    Console.WriteLine("Invalid input!");
}

var results = UserDatabase.Search(id, name, age);

foreach (var user in results)
{
    Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}

