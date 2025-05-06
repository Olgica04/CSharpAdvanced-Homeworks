using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Domain.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }

        public Employee(int id, string name, double salary, long phoneNumber, string address)
        {
            Id = id;
            Name = name;
            Salary = salary;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
