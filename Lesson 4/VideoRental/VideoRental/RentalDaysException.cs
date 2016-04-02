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
        {
            Days = days;
        }
    }
}
