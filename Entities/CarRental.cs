namespace Interfaces.entities
{
    class CarRental
    {
        private DateTime start;
        private DateTime finish;

        public CarRental(DateTime start, DateTime finish)
        {
            this.start = start;
            this.finish = finish;
        }
    }
}
