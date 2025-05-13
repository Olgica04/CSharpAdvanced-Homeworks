
namespace Task2.Domain.Models
{
    public abstract class Vehicle
    {
        public int Id { get; set; }

        public abstract void DisplayInfo();
    }
}
