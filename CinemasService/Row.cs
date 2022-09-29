using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemasService
{
    public class Row
    {
        private const int NUMBER_OF_SEATS = 5;
        public Seat[] Seats; 

        public Row ()
        {
            Seats = new Seat [NUMBER_OF_SEATS];
        }

    }
}
