using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemasService
{
    public class CinemaHall
    {
        private const int NUMBER_OF_ROWS = 3;
        private enum Letters { A, B, C, NUMBER_OF_ROWS }
        public Row[] Rows;

        //myItemArray[(int)ITEM_2];

        
        public CinemaHall ()
        {
            Rows = new Row [(int)NUMBER_OF_ROWS];
        }

    }
}
