using BoatUI.Background.Serial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoatUI.Background
{
    //This is a class that holds and manages all of the background loops that mentains the boat.
    class BackgroundApp
    {
        //Here are all of the moduels for the programs features
        //This mamages the serial port connection
        private SerialPortModule _serialport;

        //This is the thread that we are running the background loop on.
        private Thread _backroundLoopThread;


        //Here are the variables that controll the background app
        //Controlls the main thread loop
        private bool _shouldRun;

        
        public BackgroundApp()
        {
            _serialport = new SerialPortModule();
        }

        //This method is used to run the background update delay is there to limit the clock speed
        public void StartThreadBackground(int delay = 0)
        {
            //pre loop code goes here

            //The thread starter for the background Loop
            _backroundLoopThread = new Thread(() => this.BackgroundLoop(1));
            _backroundLoopThread.Start();

            //Post thread start code here 

        }

        //This method is here to close the background loop.
        public void StopBackGround()
        {
            //Pre stop code here


            //Stops the thread loop
            _shouldRun = false;
            //Closes the thread
            _backroundLoopThread.Join();
        }

        private void BackgroundLoop(int delay)
        {
            _shouldRun = true;
            while (_shouldRun)
            {
                //This code gets run every time it loops
                _serialport.ClearQue();


                //Code that delays the thread
                Thread.Sleep(delay);
            }

            //Post closing code here
            _serialport.ClosePort();
        }

    }
}
