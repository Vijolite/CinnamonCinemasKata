using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemasService
{
    public class Seat
    {
        public bool IsEmpty { get; set; }
        public Seat ()
        {
            IsEmpty = true;
        }
        public void Allocate()
        {
            IsEmpty = false;
        }
    }
}
