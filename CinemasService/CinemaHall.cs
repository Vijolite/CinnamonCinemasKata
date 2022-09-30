using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CinemasService
{
    public class CinemaHall
    {
        private const int NUMBER_OF_ROWS = 3;
        
        public Row[] Rows;

        public CinemaHall ()
        {
            int x = 0;
            Rows = new Row [NUMBER_OF_ROWS];
            foreach (var row in Rows)
            {
                int y = 0;
                foreach (var seat in row.Seats)
                {
                    seat.X = x;
                    seat.Y = y;
                    y++;
                }
                x++;
            }                  
        }

        public bool IsEmptySeat (char letter, int number)
        {
            return Rows[Convertions.ConvertRowLetter(letter)].Seats[Convertions.ConvertSeatNumber(number)].IsEmpty;
        }
        public Seat FirstEmptySeat ()
        {
            var seat = new Seat(0, 0);
            return seat;
        }
        public Seat NextEmptySeat(Seat seat)
        {

        }
        public void AllocateSeats(int number)
        {

        }
    }
}
