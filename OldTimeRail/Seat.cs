using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Seat
    {
        public int seatNumber;

        public int bookingRef { get; set; }

        public Seat(int seatNumber)
        {
            this.seatNumber = seatNumber;
            this.bookingRef = 0;
        }
    }
}
