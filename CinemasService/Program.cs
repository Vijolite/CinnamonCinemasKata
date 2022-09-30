using CinemasCervice;

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
            }
            
        }
    }
}
