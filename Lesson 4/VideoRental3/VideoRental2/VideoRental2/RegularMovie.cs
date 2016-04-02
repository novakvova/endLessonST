using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class RegularMovie : Movie
    {
        public RegularMovie(string name)
            :base(name, 2)
        {
        }
    }
}
