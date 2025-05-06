using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Domain.Models
{
    public class Manager : Employee
    {
        public string DepartmentInCharge { get; set; }
        public double Bonus { get; set; }

        public Manager (int id, string name, double salary, long phoneNumber, string address, string departmentInCharge, double bonus) :
            base (id,name,salary,phoneNumber,address)
        {
            DepartmentInCharge = departmentInCharge;
            Bonus = bonus;
        }
        public override double CalculateSalary()
        {
            return Bonus + Salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} has {PhoneNumber} number and lives at {Address}. It is in charge for: {DepartmentInCharge} and gets {CalculateSalary()} salary.");
        }
    }
}
