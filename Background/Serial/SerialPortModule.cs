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
        public static int[] BaudRate = { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200 };

        private SerialPort _port;

        private ThreadSafeQue<string> _sendDataQue;
        private ThreadSafeQue<string> _readDataQue;

        public ThreadSafeQue<string> SendDataQue { get => _sendDataQue; }
        public ThreadSafeQue<string> ReadDataQue { get => _readDataQue; }

        public string PortName { get => _port.PortName; }

        //This is the thread lock
        private object _lock = new object();

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

        //Function that is used to open the serial port.
        public void OpenPort(string portName, int baudRate)
        {
            if (_port.IsOpen)
            {
                Console.WriteLine("Port is already open");
                return;
            }
            _port.PortName = portName;
            _port.BaudRate = baudRate;
            _port.Open();
        }

        //Public method used to close the port.
        internal void ClosePort()
        {
            //Checks if the port is already closed.
            if (_port.IsOpen)
            {
                Console.WriteLine("Port has been closed.");
                _port.Close();
                return;
            }
            Console.WriteLine("The port is already closed.");
        }

        //Function that is used to update the com port
        public void UpdateComPort(string portName, int index)
        {
            lock (_lock)
            {
                //Safty checks
                if (index < 0 || index > BaudRate.Length)
                {
                    Console.WriteLine("Index out of bounds err.");
                    return;
                }

                //Closes ports before opening a new one
                if (_port.IsOpen)
                {
                    Console.WriteLine("Port has been closed.");
                    _port.DataReceived -= DataReceivedHandler;
                    _port.Close();
                }
                _port.PortName = portName;
                _port.BaudRate = BaudRate[index];
                _port.DtrEnable = true;
                _port.DataReceived += DataReceivedHandler;
                _port.Open();
                Console.WriteLine("Port: " + portName + " was opened with baudrate of " + BaudRate[index] + " bits.");
            }
        }

        //Event driven method
        //Activates if there is data on port
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            _readDataQue.Add(sp.PortName + ": " + sp.ReadExisting());
        }

        public void ClearWriteQue()
        {
            lock (_lock)
            {
                //Return if the port is closed 
                if (!_port.IsOpen)
                    return;

                //For each item in the que we are going to loop through
                foreach (var item in _sendDataQue.TakeWork())
                {
                    //We are going to write each item in the que to the serial port as a new line.
                    _port.WriteLine(item);
                }
            }
        }

        public void SendData(string data)
        {
                //Return if the port is closed 
                if (!_port.IsOpen)
                    return;
            _port.WriteLine(data);
        }

        //Static function to stringafy the BaudRate enum
        public static string[] AvalableBaudRates()
        {
            string[] rates = new string[BaudRate.Length];
            for (int i = 0; i < rates.Length; i++)
            {
                rates[i] = BaudRate[i].ToString() + " bits";
            }
            return rates;
        }

        //Returns all avalable com ports
        public static string[] AvalablePorts()
        {
            return SerialPort.GetPortNames();
        }

    }
}
