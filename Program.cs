using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureinfo = new CultureInfo("pt-BR");
            
            Console.WriteLine("Enter the rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            string stringstart = Console.ReadLine();
            DateTime start = DateTime.Parse(stringstart, cultureinfo);
            
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            string stringfinish = Console.ReadLine();
            DateTime finish = DateTime.Parse(stringfinish, cultureinfo);
            
            Console.Write("Enter the price per hour: ");
            double priceperhour = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the price per day: ");
            double priceperday = double.Parse(Console.ReadLine());


            RentalService rentalservice = new RentalService(priceperhour, priceperday, new BrazilTaxService());
            CarRental carrental = new CarRental(start,finish,new Vehicle(model));
            rentalservice.Processinvoice(carrental);
            Console.WriteLine("Invoice");
            Console.WriteLine(carrental.invoice);
        }
    }
}