using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26TcpLED
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private StreamWriter writer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ip = this.txtIP.Text;
            if (!string.IsNullOrEmpty(ip))
            {
                //Verbindungsversuch nur, wenn etwas eingegeben wurde
                try
                {
                    IPAddress address = IPAddress.Parse(ip);
                    int port = (int)this.nudPort.Value;
                    IPEndPoint ipEndPoint = new IPEndPoint(address, port);
                    this.tcpClient = new TcpClient();
                    this.tcpClient.Connect(ipEndPoint);
                    writer = new StreamWriter(this.tcpClient.GetStream());          //von der bestehenden Verbindung wird der Stream
                                                                                    //zur Kommunikation verwendet--> schreiben
                    this.btnConnect.Enabled = false;
                    receiveAsync();
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Bitte eine gültige IP angeben: ");
                }
            }
        }

        private async void receiveAsync()
        {
            StreamReader reader = new StreamReader(this.tcpClient.GetStream());
            while (true)
            {
                string incoming = await reader.ReadLineAsync();       //im Hintergrund lesen
                this.txtIncoming.Invoke(new Action(() =>
                {
                    this.txtIncoming.AppendText(incoming);
                }));
            }

            reader.Close();         //schließt den Stream wieder
        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            sendMessage("on\n");
        }

        private void sendMessage(string message)
        {
            try
            {
                this.writer.Write("on\n");      //schreibt vorerst mal in einen internen Buffer
                this.writer.Flush();            //jetzt den Inhalt des Buffers schreiben.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uuuups etwas ist schief gelaufen." + ex.StackTrace);
            }
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            sendMessage("off\n");
        }

    }
}
