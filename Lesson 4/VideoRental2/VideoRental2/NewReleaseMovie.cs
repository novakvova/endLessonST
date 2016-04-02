using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string name)
            :base(name, 3)
        {
        }
    }
}
