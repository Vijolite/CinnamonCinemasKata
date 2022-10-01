

namespace CinemasService
{
    public class Row
    {
        public const int NUMBER_OF_SEATS = 5;
        public Seat[] Seats; 

        public Row ()
        {
            Seats = new Seat [NUMBER_OF_SEATS];
        }


    }
}
