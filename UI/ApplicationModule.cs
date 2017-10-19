using BoatUI.UI.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.UI
{
    class ApplicationModule
    {
        //This is the ui window for the controlls
        ControllUI controllWindow;
        public ApplicationModule()
        {
            controllWindow = new ControllUI();
        }
    }
}
