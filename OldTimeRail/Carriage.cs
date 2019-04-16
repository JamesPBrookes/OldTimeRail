using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Carriage
    {
        public string carriageID;
        public List<Seat> seats;
        public int carriageClass { get; set; }

        public Carriage()
        {
            seats = new List<Seat>();
        }
    }
}
