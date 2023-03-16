using Interfaces.Entities;

namespace Interfaces.Services
{
    internal class RentalService
    {
        public double priceperhour { get; private set; }
        public double priceperday { get; private set; }
        
        private ITaxService taxservice;

        public RentalService(double priceperhour, double priceperday, ITaxService taxservice)
        {
            this.priceperhour = priceperhour;
            this.priceperday = priceperday;
            this.taxservice = taxservice;
        }

        public void Processinvoice(CarRental carrental)
        {
            TimeSpan dutarion = carrental.finish.Subtract(carrental.start);

            double basicpayment = 0.0;
            if(dutarion.TotalHours <= 12)
            {
                basicpayment = priceperhour * Math.Ceiling(dutarion.TotalHours);
            }
            else
            {
                basicpayment = priceperday * Math.Ceiling(dutarion.TotalDays);
            }

            double tax = taxservice.Tax(basicpayment);

            carrental.invoice = new Invoice(basicpayment, tax);
        }
    }
}
