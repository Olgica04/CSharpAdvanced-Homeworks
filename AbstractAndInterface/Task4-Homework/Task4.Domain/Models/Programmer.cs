using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Domain.Models
{
    public class Programmer : Employee
    {
        public List<string>  ProgrammingLanguages { get; set; }
        public string ProjectName { get; set; }
        public double Bonus { get; set; }

        public Programmer(int id, string name, double salary, long phoneNumber, string address, List<string> programmingLanguages, string projectName, double bonus):
            base (id,name,salary,phoneNumber,address)
        {
            ProgrammingLanguages = programmingLanguages == null ? new List<string>() : programmingLanguages;
            ProjectName = projectName;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return Bonus + Salary;
        }

        public override void DisplayInfo()
        {
            
            Console.WriteLine($"{Name} works as a developer at a project - {ProjectName}. Gets salary: {CalculateSalary()}");
            foreach(string language in ProgrammingLanguages)
            {
                Console.WriteLine($"Programming in {language}");
            }

        }
    }
}
