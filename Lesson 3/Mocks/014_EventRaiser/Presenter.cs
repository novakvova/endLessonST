using System;

namespace _014_EventRaiser
{
    class Presenter
    {
        IModel model = null;
        IView window = null;

        public Presenter(IView window, IModel model)
        {
            this.model = model;
            this.window = window;
            this.window.Load += new EventHandler(View_Load);
        }

        void View_Load(object sender, System.EventArgs e)
        {
            model.DoSomeWork();
        }
    }
}
