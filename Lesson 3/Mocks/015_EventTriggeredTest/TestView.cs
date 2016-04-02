using System;

namespace _015_EventTriggeredTest
{
    public class TestView : IView
    {
        public event EventHandler Load;

        public void LoadEventTrigger(object sender, EventArgs e)
        {
            Load.Invoke(sender, e);
        }
    }
}
