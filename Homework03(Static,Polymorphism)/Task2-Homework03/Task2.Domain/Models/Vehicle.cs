using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Domain.Models
{
    public abstract class Vehicle
    {
        public int Id { get; set; }

        public abstract void DisplayInfo();
    }
}
