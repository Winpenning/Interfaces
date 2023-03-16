﻿namespace Interfaces.Entities
{
    internal class CarRental
    {
        public DateTime start { get; set; }
        public DateTime finish { get; set; }
        public Vehicle vehicle { get; set; }
        public Invoice? invoice { get; set; }
        public CarRental() { }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            this.start = start;
            this.finish = finish;
            this.vehicle = vehicle;
            this.invoice = null;
        }
    }
}