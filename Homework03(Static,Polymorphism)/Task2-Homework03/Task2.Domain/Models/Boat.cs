
namespace Task2.Domain.Models
{
    public class Boat : Vehicle
    {

        public override void DisplayInfo()
        {
            Console.WriteLine("I am a boat and I do not have wheels!");
        }

     
    }
}
