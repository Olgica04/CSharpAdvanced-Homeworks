using Task2.Domain.Interfaces;

namespace Task2.Domain.Models
{
    public class MotorBike : Vehicle, IMotorBike
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a motorbike and I drive on 2 wheels!");
        }

        public void Wheelie()
        {
            Console.WriteLine("Driving on one wheel");
        }
    }
}
