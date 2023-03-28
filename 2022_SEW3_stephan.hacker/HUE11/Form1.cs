using HUE11_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HUE11
{
    public partial class Form1 : Form
    {
        private ArduinoSerialPortCommunication arduino1;
        String status = "000";
        String eingabePuffer = "";

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

            foreach (char item in textFromArduino)
            {
                if (item != '\n')
                {
                    eingabePuffer += item;
                }
                else
                {
                    status = eingabePuffer;
                    eingabePuffer = "";
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(status[0] == '0') {
                arduino1.write("red on\n");
                button1.Text = "Rote LED eingeschalten";
            }
            else
            {
                arduino1.write("red off\n");
                button1.Text = "Rote LED ausgeschalten";
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (status[1] == '0')
            {
                arduino1.write("green on\n");
                button2.Text = "Grüne LED eingeschalten";
            }
            else
            {
                arduino1.write("green off\n");
                button2.Text = "Grüne LED ausgeschalten";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (status[2] == '0')
            {
                arduino1.write("blue on\n");
                button3.Text = "Blaue LED eingeschalten";
            }
            else
            {
                arduino1.write("blue off\n");
                button3.Text = "Blaue LED ausgeschalten";
            }
        }
    }
}
