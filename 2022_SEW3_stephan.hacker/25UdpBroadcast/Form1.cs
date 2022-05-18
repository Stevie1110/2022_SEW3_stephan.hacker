using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25UdpBroadcast
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private int port = 8888;
        public Form1()
        {
            InitializeComponent();
            IPEndPoint receiveAdr = new IPEndPoint(IPAddress.Any, port);
            udpClient = new UdpClient(receiveAdr);
            this.receiveAsync();
        }

        private async void receiveAsync()         //diese Methode wird in einem Hintergrungthread ausgeführt,
                                            //damit unsere GUI nicht blockiert.
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();           //wait und async wird nächstes Jahr erklärt
                this.txtLog.Text += Encoding.UTF8.GetString(result.Buffer)+Environment.NewLine;
                this.txtLog.Update();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] message = Encoding.UTF8.GetBytes(this.txtMessage.Text);
                IPEndPoint broadCastIP = new IPEndPoint(IPAddress.Broadcast, this.port);
                udpClient.Send(message, message.Length, broadCastIP);       //Daten, Länge der Daten, Empfänger
            }catch(SocketException se)
            {
                this.txtLog.Text += se.Message + Environment.NewLine;
            }
        } 
    }
}
