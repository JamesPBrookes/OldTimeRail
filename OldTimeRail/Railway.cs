using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Railway
    {
        public static List<Train> trains;
        
        public Railway()
        {
            trains = new List<Train>();
            trains.Add(new Train (1, "09:00", "Sat", "Endline"));
            trains.Add(new Train (2, "11:00", "Sun", "Endline"));
            trains.Add(new Train (3, "11:00", "Sat", "Beggin"));
            trains.Add(new Train (4, "13:00", "Sun", "Beggin"));

        }

 
    }
}
