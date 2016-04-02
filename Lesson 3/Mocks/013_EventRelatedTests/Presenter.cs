using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_EventRelatedTests
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
            throw new NotImplementedException();
        }
    }
}
