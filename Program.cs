using System;
using Interfaces.entities;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carmodel = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
            string pickupdate = Console.ReadLine();
            Console.Write("Return (dd/mm/yyyy hh:mm): "); 
            string returndate = Console.ReadLine();
            Console.Write("Enter price per hour: ");
            double priceperhour = double.Parse(Console.ReadLine());
            Console.Write("Enter the price per day: ");
            double priceperday = double.Parse(Console.ReadLine());


            Console.WriteLine("INVOICE:");
        }
    }
}