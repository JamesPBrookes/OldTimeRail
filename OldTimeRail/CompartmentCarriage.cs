using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class CompartmentCarriage: Carriage
    {
        

        public CompartmentCarriage(string ID, int carClass)
        {
            this.carriageID = ID;
            this.carriageClass = carClass;

            for (int seatNumber = 0; seatNumber < 32; seatNumber ++)
            {
                seats.Add(new Seat(seatNumber + 1));

            }
        }
    }
}
