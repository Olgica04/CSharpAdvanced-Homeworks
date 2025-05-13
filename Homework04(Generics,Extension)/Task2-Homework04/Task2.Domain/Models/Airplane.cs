using Task2.Domain.Interfaces;

namespace Task2.Domain.Models
{
    public class Airplane : Vehicle, IAirplane
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a plane, I have couple of wheels!");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
