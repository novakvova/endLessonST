using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModal.Entity
{
    public class Movie
    {
        private double rentalPrice;

        public Movie(double rentalPrice)
        {
            
            this.rentalPrice = rentalPrice;
        }
    }
}
