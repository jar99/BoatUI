using BoatUI.Background;
using BoatUI.UI.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatUI.UI
{
    class ApplicationModule : ApplicationContext
    {
        private BackgroundApp background;

        //This is the ui window for the controlls
        ControllUI controllWindow;
        public ApplicationModule()
        {
            background = new BackgroundApp();
            controllWindow = new ControllUI();

            //Function that is going to link events
            linkEvents();

            //Links the closing of the form to the close function
            controllWindow.FormClosed += ((s, e) => { CloseAplication(); ExitThread(); });
            background.StartBackgroundThread();

            //First update to get the right data
            UpdateForms();
            //Showing form after first update
            controllWindow.Show();

            SetUPRefreshLoop(1);
        }

        //Sets up the event linking for the background
        private void linkEvents()
        {

            controllWindow.UpdateComPort += ((s, i) => background.Serialport.UpdateComPort(s, i));
            controllWindow.SendData += ((s) => background.Serialport.SendData(s));
        }

        //Sets up a timer for the refresh call
        private void SetUPRefreshLoop(int v)
        {
            //Sets up a refresh event
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (v * 1000);
            timer.Tick += new EventHandler((s, e) => UpdateForms());
            timer.Start();
        }

        //This calles all of the froms that have to be updated
        private void UpdateForms()
        {
            string sender = background.Serialport.PortName;
            foreach (var text in background.Serialport.ReadDataQue.TakeWork())
            {
                controllWindow.UpdateTextBox(sender, text);
            }
            
        }

        //Function that is called to close the remaining things.
        private void CloseAplication()
        {
            background.StopBackGround();
        }

    }
}
