using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class RentalDaysException : Exception
    {
        public object Days { get; private set; }

        public RentalDaysException(int days)
            :base(string.Format("Rental days can not be negative ({0} days)", days))
        {
            Days = days;
        }
    }
}
