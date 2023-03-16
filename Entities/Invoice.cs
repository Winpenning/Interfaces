using System.Globalization;

namespace Interfaces.Entities
{
    internal class Invoice
    {
        public double basicPayment { get; set; }
        public double tax { get; set; }
        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
        }
        public double TotalPayment { get { return basicPayment + tax; } }
        public override string ToString()
        {
            return "basic payment: " + basicPayment.ToString("F2")
                + "\nTax: "
                + tax.ToString("F2")
                + "\nTotal payment: "
                + TotalPayment.ToString("F2");
        }
    }
}

