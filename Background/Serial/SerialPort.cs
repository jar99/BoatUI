using BoatUI.Background.HelpData;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.Background.Serial
{

    class SerialPortModule
    {
        public static int[] BaudRate = { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };

        private SerialPort _port;

        private ThreadSafeQue<string> _sendDataQue;
        private ThreadSafeQue<string> _readDataQue;

        public ThreadSafeQue<string> SendDataQue { get => _sendDataQue; }
        internal ThreadSafeQue<string> ReadDataQue { get => _readDataQue; }

        //Constructor for the serial module
        public SerialPortModule()
        {
            //Creates the object masters. These should not be changed at all
            //We acses only these the copys elsewere.
            _sendDataQue = new ThreadSafeQue<string>();
            _readDataQue = new ThreadSafeQue<string>();

            //Creating hte prot
            _port = new SerialPort();
        }

        public void OpenPort(string portName, int baudRate)
        {
            if (_port.IsOpen)
            {
                Console.WriteLine("Port is already open");
                return;
            }
            _port.PortName = portName;
            _port.BaudRate = baudRate;
            _port.DtrEnable = true;
        }

        internal void ClearQue()
        {
            throw new NotImplementedException();
        }

        internal void ClosePort()
        {
            throw new NotImplementedException();
        }
    }
}
