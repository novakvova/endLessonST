using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental2
{
    public class Movie
    {
        private string name;
        double rentalPrice;
        MovieType type;

        public string Name { get { return name; } }
        public double RentalPrice { get { return rentalPrice; } }
        public MovieType Type { get { return type; } }

        protected Movie(string name, double rentalPrice, MovieType type)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.rentalPrice = rentalPrice;
            this.type = type;
        }

        public static Movie RegularMovie(string name)
        {
           return new Movie(name, 2, MovieType.Regular);
        }

        public static Movie ChildrensMovie(string name)
        {
            return new Movie(name, 1, MovieType.Childrens);
        }

        public static Movie NewReleaseMovie(string name)
        {
            return new Movie(name, 3, MovieType.NewRelease);
        }
    }
}
