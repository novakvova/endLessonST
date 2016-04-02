using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _015_EventTriggeredTest
{
    public interface IView
    {
        event EventHandler Load;

        void LoadEventTrigger(object sender, EventArgs e);
    }
}
