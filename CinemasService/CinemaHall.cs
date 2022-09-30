using System;
using System.Collections.Generic;
using System.Data;
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
            Rows = new Row [NUMBER_OF_ROWS];
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                Rows [i] = new Row ();
                for (int j = 0; j < Row.NUMBER_OF_SEATS; j++)
                {
                    Rows[i].Seats[j] = new Seat(i, j);
                }
            }              
        }

        public bool IsEmptySeat (char letter, int number)
        {
            return Rows[Convertions.ConvertRowLetter(letter)].Seats[Convertions.ConvertSeatNumber(number)].IsEmpty;
        }
        public Seat FirstEmptySeat ()
        {
            bool found = false;
            int i = 0;
            int j = 0;
            for (i = 0; i < NUMBER_OF_ROWS && !found; i++)
            {
                for (j = 0; j < Row.NUMBER_OF_SEATS && !found; j++)
                {
                    if (Rows[i].Seats[j].IsEmpty) found = true;
                }
            }
            return Rows[i-1].Seats[j-1];
        }
        public Seat NextEmptySeat(Seat seat)
        {           
            if (seat.Y == Row.NUMBER_OF_SEATS-1)
                return Rows[seat.X+1].Seats[0];
            else
                return Rows[seat.X].Seats[seat.Y + 1];
        }
        public void AllocateSeats(int number)
        {
            var seat = new Seat();
            for (int i = 0; i < number; i++)
            {
                if (i == 0) seat = FirstEmptySeat();
                else seat = NextEmptySeat(seat);
                seat.Allocate();
            }
            

        }
    }
}
