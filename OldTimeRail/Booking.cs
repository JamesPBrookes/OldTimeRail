using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Booking
    {
        private static int nextBookingRef = 0;
        private int bookingRef;

        public string[] seats;
        
        public Booking()
        {
            nextBookingRef ++;
            this.bookingRef = nextBookingRef;
        }

        //public string TravelDay { get; set; }
        public int TravelClass { get; set;  }
        public int TrainNumber { get; set; }
        public int NumberOfPassengers { get; set; }
        public int NumberOfSuitcases { get; set; }
        
        public static int NextBookingRef
        {
            get
            {
                return nextBookingRef;
            }
        }

        public int BookingRef
        {
            get
            {
                return this.bookingRef;
            }
        }

        public bool GetSeats()
        {
            bool success = true;

            switch (TravelClass)
            {
                case 1:
                    //List<Carriage> cars = new List<Carriage>();
                    foreach (Carriage car in Railway.trains[TrainNumber - 1].carriages)
                    {
                        if (car.carriageClass == 1)
                        {
                            int seatsFound = 0;
                            
                            foreach (Seat s in car.seats)
                            {
                                if(s.bookingRef == 0)
                                {                                   
                                    seatsFound++;
                                }
                            }
                            if (seatsFound >= NumberOfPassengers)
                            {                                         
                                seatsFound = 1;
                                int i = 0;
                                seats = new string[NumberOfPassengers];

                                foreach (Seat s in car.seats)
                                {
                                    if (s.bookingRef == 0 && seatsFound <= NumberOfPassengers)
                                    {
                                        s.bookingRef = this.bookingRef;
                                        seatsFound++;
                                        seats[i] = car.carriageID + s.seatNumber.ToString("D2");
                                        i++;                                        
                                    }
                                }                                
                            }
                            else 
                            {
                                success = false;                                
                            }
                        }
                    }
                    
                        
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("\nInvalid travel class");
                    break;
            }

            return success;
        }
    }
}
