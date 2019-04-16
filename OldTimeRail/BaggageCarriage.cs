using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class BaggageCarriage: Carriage
    {
        public BaggageCarriage(string ID)
        {
            this.carriageID = ID;
            
            for (int slotNumber = 1; slotNumber < 41; slotNumber++)
            {
                seats.Add(new Seat(slotNumber));
            }
        }
    }
}
