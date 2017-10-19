using BoatUI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatUI
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //This starts the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationModule());


        }
    }
}
