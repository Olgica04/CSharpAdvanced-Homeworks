using Task2.Domain.Interfaces;

namespace Task2.Domain.Models
{
    public class Boat : Vehicle, IBoat
    {

        public override void DisplayInfo()
        {
            Console.WriteLine("I am a boat and I do not have wheels!");
        }

        public void Sail()
        {
            Console.WriteLine("Sailing");
        }
    }
}
