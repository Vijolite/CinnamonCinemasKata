using System;
using CinemasService.Models;

namespace CinemasService.Helpers
{
    public static class Output
    {
        public static void PrintAllSeats(CinemaHall cinema)
        {
            for (int i = 0; i < CinemaHall.NUMBER_OF_ROWS; i++)
            {
                Console.Write($"Row {Convertions.ConvertRowNumberBackToHuman(i)}: ");
                for (int j = 0; j < Row.NUMBER_OF_SEATS; j++)
                {
                    Console.Write($"{cinema.Rows[i].Seats[j].IsEmpty} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }


    }
}