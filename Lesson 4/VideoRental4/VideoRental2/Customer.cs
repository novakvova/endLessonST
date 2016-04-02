using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class Customer
    {
        private string name;
        private List<Renatal> rentals = new List<Renatal>();

        public List<Renatal> Rentals { get { return rentals; } }
        public string Name { get { return name; } }

        public Customer(string name)
        {
            this.name = name;
        }

        public object CalculateDebt()
        {
            double totalAmount = 0;

            foreach (var rental in rentals)
                totalAmount += rental.Days * rental.Movie.RentalPrice;

            return totalAmount;
        }
    }
}
