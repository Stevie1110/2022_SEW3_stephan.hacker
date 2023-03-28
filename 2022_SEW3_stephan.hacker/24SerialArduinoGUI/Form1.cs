using _22SerialArduino;
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

namespace _24SerialArduinoGUI
{
    public partial class Form1 : Form
    {
        private ArduinoSerialPortCommunication arduino1;
        public Form1()
        {
            InitializeComponent();
            this.arduino1 = new ArduinoSerialPortCommunication("COM4");
            this.arduino1.addSerialDataReceivedEventHandler(new System.IO.Ports.SerialDataReceivedEventHandler(SerialDataReceived));
        }

        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;        //expliziter Cast, sender ist das Objekt, welches das Event ausgelöst hat
            string textFromArduino = serialPort.ReadExisting();

            //Action delegate als Lambda Methode
            this.txtMessage.Invoke(new Action(() =>
            {
                this.txtMessage.AppendText(textFromArduino);       //an den bestehenden Text anhängen.
            }));
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            this.arduino1.write("e");
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.arduino1.write("a");
        }
    }
}
