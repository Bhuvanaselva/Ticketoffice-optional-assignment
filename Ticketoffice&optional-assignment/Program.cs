// See https://aka.ms/new-console-template for more information

using System;
using Ticketoffice_optional_assignment;

Console.WriteLine("Welcome to the Ticket Booking!\n");
int age = Class1.GetAge();
string place = Class1.GetTicket();
int price = Class1.PriceSetter(age, place);
decimal tax = Class1.TaxCalculator(price);
int ticketNumber = Class1.TicketNumberGenerator();
Console.WriteLine("\nTicket Details:");
Console.WriteLine($"Age: {age} years");
Console.WriteLine($"Place preference: {place}");
Console.WriteLine($"Total Price: {price} SEK");
Console.WriteLine($"Tax (6%): {tax} SEK");
Console.WriteLine($"Ticket Number: {ticketNumber}\n");

string placeList = ",34,1003,389,4100,4890,7233,2855,";

Console.WriteLine("Please choose PlaceNumber if you have 'seated' ticket or 'Exit' \n");

while (true)
{

    Console.WriteLine("1. Check Place Availability");
    Console.WriteLine("2. Add a Place");
    Console.WriteLine("3. Exit");
    Console.WriteLine("\nEnter your choice (1/2/3): ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("\nEnter Place Number: ");
            int placeNumber = Convert.ToInt32(Console.ReadLine());
            bool isAvailable = Class1.CheckPlaceAvailability(placeList, placeNumber);

            if (isAvailable)
            {
                Console.WriteLine($"Place {placeNumber} is available:{isAvailable}\n");
            }
            else
            {
                Console.WriteLine($"Place {placeNumber} is sold :{isAvailable}");
                Console.WriteLine("\nSold Places: ");
                Console.WriteLine(placeList + "\n");
            }
            break;

        case 2:
            Console.WriteLine("\nEnter Place Number to add: ");
            int placeToAdd = Convert.ToInt32(Console.ReadLine());
            placeList = Class1.AddPlace(placeList, placeToAdd);
            Console.WriteLine("Place {0} has been added successfully.", placeToAdd);
            Console.WriteLine("\nUpdated PlaceList: ");
            Console.WriteLine(placeList + "\n");
            break;

        case 3:
            Console.WriteLine("Thank you for booking!!");
            return;

        default:
            Console.WriteLine("Invalid Choice. Please try again.");
            break;
           
    }
}

