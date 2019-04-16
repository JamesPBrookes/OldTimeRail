using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class UserInterface
    {

        Railway railway;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public UserInterface()
        {
            railway = new Railway();
            while (DisplayMenu());
        }

        /// <summary>
        /// Displays the main menu 
        /// </summary>
        private bool DisplayMenu()
        {
            bool carryOn = true;
            Console.Clear();
            Console.WriteLine("Old-time Rail Booking System");
            Console.WriteLine("");
            Console.WriteLine("Please select an option from below:");
            Console.WriteLine("1) Add a booking");
            Console.WriteLine("2) Display bookings");
            Console.WriteLine("0) Exit Program");

            bool validInput = false;

            do
            {
                validInput = true;
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        AddBooking();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                       // DisplayBookings();
                        break;                 
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        carryOn = false;
                        Console.WriteLine("\nProgram Closed, Press Enter.");
                        break;
                    default:
                        Console.WriteLine("\nPlease enter a valid number from the options above.");
                        validInput = false;
                        break;
                }
            } while (!validInput);

            return carryOn;
        }

        private void AddBooking()
        {
            Console.Clear();
            Console.WriteLine("New Booking\n");

            Booking newBooking = new Booking();

            newBooking.TrainNumber = GetTrain("When will you be traveling?");
            newBooking.TravelClass = GetClass("What Class will you be traveling?");
            newBooking.NumberOfPassengers = GetInt("\nHow many passengers are in your party?");
            if (newBooking.GetSeats())
            {
                Console.WriteLine("Seats Sucessfully Booked:");
                for (int i = 0; i < newBooking.seats.Length; i++)
                {
                    Console.WriteLine("Seat Number: {0}", newBooking.seats[i]);
                }
                newBooking.NumberOfSuitcases = GetInt("How many suitcases does your party have?");
            }
            else
            {
                Console.WriteLine("\nBooking Failed. Please try again.");
                Console.ReadLine();
                newBooking = null;
                DisplayMenu();
            }
           
            //bool check = AskForInfoBool("Is this information correct?");

            Console.ReadLine();

        }

        int GetClass(string message)
        {
            int result = 0;
            bool validInput = false;

            Console.WriteLine("\n1) 1st Class");
            Console.WriteLine("2) 3rd Class Compartment");
            Console.WriteLine("3) 3rd Class Standard");

            do
            {
                validInput = true;
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        result = 1;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        result = 2;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        result = 3;
                        break;
                    default:
                        Console.WriteLine("\nPlease enter a valid number from the options above.");
                        validInput = false;
                        break;
                }
            } while (!validInput);

            return result;
        }

        int GetTrain(string message)
        {
            int result = 0;
            Console.WriteLine("\n1) {0} {1} {2}", Railway.trains[0].DepartureDay, Railway.trains[0].DepartureTime, Railway.trains[0].Destination);
            Console.WriteLine("2) {0} {1} {2}", Railway.trains[1].DepartureDay, Railway.trains[1].DepartureTime, Railway.trains[1].Destination);
            Console.WriteLine("3) {0} {1} {2}", Railway.trains[2].DepartureDay, Railway.trains[2].DepartureTime, Railway.trains[2].Destination);
            Console.WriteLine("4) {0} {1} {2}", Railway.trains[3].DepartureDay, Railway.trains[3].DepartureTime, Railway.trains[3].Destination);

            bool validInput = false;

            do
            {
                validInput = true;
                ConsoleKeyInfo key = Console.ReadKey();
             
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        result = 1;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        result = 2;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        result = 3;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        result = 4;
                        break;
                    default:
                        Console.WriteLine("\nPlease enter a valid number from the options above.");
                        validInput = false;
                        break;
                }
            } while (!validInput);

            return result;
        }

        int GetInt(string message)
        {
            int result = 0;
            string userInput;
            bool success = false;
            Console.WriteLine(message);
            while (!success)
            {
                userInput = Console.ReadLine();
                if (!Int32.TryParse(userInput, out result))
                {
                    Console.WriteLine("Please enter a whole number.");
                }
                else
                {
                    success = true;
                }
            }
            return result;
        }
    }
}
