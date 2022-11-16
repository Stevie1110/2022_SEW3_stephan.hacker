using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Hue01
{
    public partial class Form1 : Form
    {
        private int port1 = 8888;
        private UdpClient udpClient;
        public Form1()
        {

        }

        private void btn_Daten_Click(object sender, EventArgs e)
        {
            IPEndPoint receiveAdr = new IPEndPoint(IPAddress.Any, port1);
            udpClient = new UdpClient(receiveAdr);
            this.ReceiveAsync();
        }

        private async void ReceiveAsync()
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                this.txt_akt_Temp.Text = Encoding.UTF8.GetString(result.Buffer) + Environment.NewLine;
            }
        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_akt_Temp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mitt_Temp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}