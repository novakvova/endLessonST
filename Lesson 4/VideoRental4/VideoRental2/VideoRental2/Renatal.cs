using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental2
{
    public class Renatal
    {
        private Movie movie;
        private int days;

        public Movie Movie { get { return movie; } }

        public int Days
        {
            get { return days; }
            private set
            {
                if (value < 0)
                    throw new RentalDaysException(value);

                days = value;
            }
        }

        public Renatal(Movie movie, int days)
        {
            // TODO: Complete member initialization
            this.movie = movie;
            this.Days = days;
        }

        public double CalculateDebt()
        {
                return Days * movie.RentalPrice;
        }

        public void AddRentalDays(int days = 1)
        {
            this.Days += days;
        }

        public void SubstractRentalDays(int days = 1)
        {
            this.Days -= days;
        }
    }
}
