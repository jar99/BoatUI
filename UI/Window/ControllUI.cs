using BoatUI.Background.HelpData;
using BoatUI.Background.Serial;
using BoatUI.UI.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatUI.UI.Window
{
    public partial class ControllUI : Form
    {
        //Variables
        private PointLine rudder;
        internal event Action<string, int> UpdateComPort;

        internal event Action<string> SendData;

        public ControllUI()
        {

            InitializeComponent();

            rudder = new PointLine(boat_graphics.Width / 2, boat_graphics.Height - (boat_graphics.Height / 4), 100);
        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            rudder.Rotate(-Math.PI / 8);
            Refresh();
        }

        private void rotateRight_Click(object sender, EventArgs e)
        {
            rudder.Rotate(Math.PI / 8);
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRudder(e);
        }

        //This is the method to draw the rudder.
        private void DrawRudder(PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Orange, 5);
            pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            graphics.DrawLine(pen, rudder.GetStartPoint, rudder.GetEndPoint);
            int size = 8;
            var rect = new RectangleF(rudder.PointX - (size / 2), rudder.PointY - (size / 2), size, size);
            graphics.FillEllipse(new SolidBrush(Color.Black), rect);

        }


        //Updates the text box
        public void UpdateTextBox(string sender, string text){

            listBox1.Items.Add(sender + ": " + text);
        }

        //Updates the comboboxes items
        private void UpdateSerialData()
        {
            //Update baudRate
            foreach (var item in SerialPortModule.AvalableBaudRates())
            {
                if (!baudRate.Items.Contains(item))
                {
                    baudRate.Items.Add(item);
                }
            }

            //Update comport items
            foreach (var item in SerialPortModule.AvalablePorts())
            {
                if (!comPort.Items.Contains(item))
                {
                    comPort.Items.Add(item);
                }
            }
        }

        private void comPort_DropDown(object sender, EventArgs e)
        {
            UpdateSerialData();
        }

        private void baudRate_DropDown(object sender, EventArgs e)
        {
            UpdateSerialData();
        }

        private void comPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comPort.SelectedItem.ToString());
            if (comPort.SelectedItem != null && baudRate.SelectedItem != null)
            {
                UpdateComPort?.Invoke(comPort.SelectedItem.ToString(), baudRate.SelectedIndex);
            }
        }

        private void baudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comPort.SelectedItem != null && baudRate.SelectedItem != null)
            {
                UpdateComPort?.Invoke(comPort.SelectedItem.ToString(), baudRate.SelectedIndex);
            }
        }

        private void comButton_Click(object sender, EventArgs e)
        {
            if (comPort.SelectedItem != null && baudRate.SelectedItem != null)
            {
                String text = sendText.Text;
                if (text.Length != 0) {
                    SendData?.Invoke(text);
                    UpdateTextBox(comPort.SelectedItem.ToString(), text);
                    sendText.Clear();
                }
            }
        }
    }
}
