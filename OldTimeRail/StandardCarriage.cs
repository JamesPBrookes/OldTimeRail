using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class StandardCarriage: Carriage
    {
        public StandardCarriage(string ID)
        {
            this.carriageID = ID;

            for (int seatNumber = 1; seatNumber < 51; seatNumber++)
            {
                seats.Add(new Seat(seatNumber));
            }
        }
    }
}
