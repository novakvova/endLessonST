using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoRental
{
    public class ChildrensMovie : Movie
    {
      
        public ChildrensMovie(string name)
            :base(name, 1)
        {
        }

    }
}
