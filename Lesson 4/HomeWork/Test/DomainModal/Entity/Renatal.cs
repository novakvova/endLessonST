using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModal.Entity
{
    public class Renatal
    {
        private Movie movie;
        private int days;

        public Renatal(Movie movie, int days)
        {
            // TODO: Complete member initialization
            this.movie = movie;
            this.days = days;
        }

        public object CalculateDebt()
        {
            return 12;
        }
    }
}
