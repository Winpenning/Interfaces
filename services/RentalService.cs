using System;
using Interfaces.entities;

namespace Interfaces.services
{
    class RentalService
    {
        private double pricePerHour;
        private double pricePerDay;
        private ITaxService taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
            this.taxService = taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.getFinish().Subtract(carRental.getStart());
            double basicaPayment = 0.0;
            if(duration.TotalHours <= 12.00)
            {
                basicaPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicaPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = taxService.tax(basicaPayment);

            Invoice invoice = new Invoice(basicaPayment, tax);
            carRental.setInvoice(invoice);
        }
    }
}
