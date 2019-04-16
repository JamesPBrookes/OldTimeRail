using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Train
    {
        public int TrainID { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureDay { get; set; }
        public string Destination { get; set; }        

        public List<Carriage> carriages;
        
        public Train(int ID, string depTime,string depDay, string dest)
        {
            carriages = new List<Carriage>();
            this.TrainID = ID;
            this.DepartureTime = depTime;
            this.Destination = dest;
            this.DepartureDay = depDay;

            carriages.Add(new CompartmentCarriage("A", 1));
            carriages.Add(new CompartmentCarriage("B", 3));
            carriages.Add(new StandardCarriage("C"));
            carriages.Add(new StandardCarriage("D"));
            carriages.Add(new BaggageCarriage("E"));

        }
    }
}
