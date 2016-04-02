using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _013_EventRelatedTests
{
    public interface IView
    {
        event EventHandler Load;
    }
}
