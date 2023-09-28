using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketoffice_optional_assignment
{
    internal class Class1
    {
        public static int GetAge()
        {
            Console.WriteLine("Please enter your age: ");
            string text = Console.ReadLine();
            int age = Convert.ToInt32(text);
            return age;
        }

        public static string GetTicket()
        {
            Console.WriteLine("\nSelect Standing or Seated ticket: ");
            string place = Console.ReadLine();
            if (place != "standing" && place != "seated")
            {
                Console.WriteLine("Invalid input. Please enter 'standing' or 'seated'.");
                return GetTicket();
            }
            return place;
        }
        public static int PriceSetter(int age, string place)
        {
            int price;

            if (age <= 11)
            {
                price = (place == "standing") ? 25 : 50;
            }
            else if (age >= 12 && age <= 64)
            {
                price = (place == "standing") ? 110 : 170;
            }
            else
            {
                price = (place == "standing") ? 60 : 100;
            }

            return price;
        }
        public static decimal TaxCalculator(int price)
        {
            decimal tax = Convert.ToDecimal((1 - 1 / 1.06) * price);
            return Math.Round(tax, 2);
        }

        public static int TicketNumberGenerator()
        {
            var rand = new Random();
            return rand.Next(1, 8000);
        }

        public static bool CheckPlaceAvailability(string placeList, int placeNumber)
        {

            string searchPattern = $",{placeNumber},";
            return !placeList.Contains(searchPattern);
        }

        public static string AddPlace(string placeList, int placeNumber)
        {
            placeList += $"{placeNumber},";
            return placeList;
        }
    }
}
