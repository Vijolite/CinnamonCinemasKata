using CinemasService.Helpers;
using CinemasService.UI;
using CinemasService.Models;

namespace CinemasService
{
    public class Program
    {
        public static void Main()
        {
            var cinema = new CinemaHall();
            int numberOfSeats = UserInterface.GenerateRandomNumberOfSeats();
            while (cinema.SeatsCouldBeAllocated(numberOfSeats))
            {
                cinema.AllocateSeats(numberOfSeats);
                Output.PrintAllSeats(cinema);
                numberOfSeats = UserInterface.GenerateRandomNumberOfSeats();
            }
            
        }
    }
}
