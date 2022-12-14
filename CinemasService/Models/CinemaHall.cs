using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CinemasService.Helpers;

namespace CinemasService.Models
{
    public class CinemaHall
    {
        public const int NUMBER_OF_ROWS = 3;

        public Row[] Rows;

        public CinemaHall()
        {
            Rows = new Row[NUMBER_OF_ROWS];
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                Rows[i] = new Row();
                for (int j = 0; j < Row.NUMBER_OF_SEATS; j++)
                {
                    Rows[i].Seats[j] = new Seat(i, j);
                }
            }
        }

        public bool IsEmptySeat(char letter, int number)
        {
            return Rows[Convertions.ConvertRowLetter(letter)].Seats[Convertions.ConvertSeatNumber(number)].IsEmpty;
        }
        public Seat FirstEmptySeat()
        {
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                for (int j = 0; j < Row.NUMBER_OF_SEATS; j++)
                {
                    if (Rows[i].Seats[j].IsEmpty) return Rows[i].Seats[j];
                }
            }
            return null;
            
        }
        public Seat NextEmptySeat(Seat seat)
        {
            if (seat.Y == Row.NUMBER_OF_SEATS - 1)
                return Rows[seat.X + 1].Seats[0];
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
        public int NumberOfEmptySeats()
        {
            return Rows.SelectMany(row => row.Seats).Where(seat => seat.IsEmpty).Count();
        }
        public bool SeatsCouldBeAllocated(int number)
        {
            return number <= NumberOfEmptySeats();
        }
    }
}
