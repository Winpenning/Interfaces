using System;
using System.Globalization;
using Interfaces.entities;
using Interfaces.services;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var ptBR = new System.Globalization.CultureInfo("pt-BR");
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carmodel = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine(), ptBR);
            Console.Write("Return (dd/mm/yyyy hh:mm): "); 
            DateTime finish = DateTime.Parse(Console.ReadLine(), ptBR);
            Console.Write("Enter price per hour: ");
            double priceperhour = double.Parse(Console.ReadLine());
            Console.Write("Enter the price per day: ");
            double priceperday = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(carmodel));
            RentalService rentalService = new RentalService(priceperhour, priceperday, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.getInvoice());
        }
    }
}