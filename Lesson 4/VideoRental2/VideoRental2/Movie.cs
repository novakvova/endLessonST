using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental
{
    public abstract class Movie
    {
        private string name;
        double rentalPrice;

        public string Name { get { return name; } }
        public double RentalPrice { get { return rentalPrice; } }

        public Movie(string name, double rentalPrice)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.rentalPrice = rentalPrice;
        }

    }
}
