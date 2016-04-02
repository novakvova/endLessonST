using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class Renatal
    {
        private Movie movie;
        private int days;

        public Renatal(Movie movie, int days)
        {
            // TODO: Complete member initialization
            this.movie = movie;
            this.Days = days;
        }


        public int Days //Проверка на отрицательное число
        {
            get { return days; }
            private set
            {
                if (value < 0)
                    throw new RentalDaysException(value);

                days = value;
            }
        }

    
        public double CalculateDebt()
        {
            return this.Days * this.movie.RentalPrice;
        }

        public void AddRentalDays(int p=1)
        {
            this.Days += p;
        }

        public void SubstractRentalDays(int p=1)
        {
            this.Days -= p;
        }
    }
}
