namespace Interfaces.entities
{
    class CarRental
    {
        private DateTime start;
        private DateTime finish;
        private Vehicle vehicle;
        private Invoice? invoice;

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            this.start = start;
            this.finish = finish;
            this.vehicle = vehicle;
            this.invoice = null;
        }

        public DateTime getStart()
        {
            return start;
        }
        public DateTime getFinish()
        {
            return finish;
        }
        public void setInvoice(Invoice invoice)
        {
            this.invoice = invoice;
        }
        public Invoice getInvoice()
        {
            return invoice;
        }
    }
}
