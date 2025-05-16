

namespace Task2.Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"This is a class for Vehicle with id: {Id}");
        }

    }
}
