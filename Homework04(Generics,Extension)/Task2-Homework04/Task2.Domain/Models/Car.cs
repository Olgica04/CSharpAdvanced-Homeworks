
using Task2.Domain.Interfaces;

namespace Task2.Domain.Models
{
    public class Car : Vehicle, ICar
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a car and I drive on 4 wheels!");
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
