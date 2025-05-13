using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Domain.Models;

namespace Task1.Domain
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; }

        static UserDatabase()
        {
            Users = new List<User>()
            {
                new User(1, "Ivan",25),
                new User(2, "Maja",35),
                new User(3, "Dejan",19),
                new User(4, "Anja",39),
                new User(5, "Simona",27)
            };
        }

        public static User SearchById(int id)
        {
            return Users.FirstOrDefault(x => x.Id == id);
        }

        public static List<User> SearchByName(string name)
        {
            return Users.Where(x => x.Name == name).ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return Users.Where(x => x.Age == age).ToList();
        }

        public static List<User> Search(int id, string name, int age)
        {
            return Users.Where(user =>
                ( user.Id == id) &&
                (string.IsNullOrEmpty(name) || user.Name.ToLower() == name.ToLower()) &&
                (user.Age == age)
            ).ToList();
        }


    }
}