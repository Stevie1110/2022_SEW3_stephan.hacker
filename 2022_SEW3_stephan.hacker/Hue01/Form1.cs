using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Hue01
{
    public partial class Form1 : Form
    {
        private int port = 8888;
        private UdpClient udpClient;
        List<Messwerte> werte = new List<Messwerte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Daten_Click(object sender, EventArgs e)
        {
            IPEndPoint receiveAdr = new IPEndPoint(IPAddress.Any, port);       // , int.Parse(this.txt_port.Text)
            udpClient = new UdpClient(receiveAdr);
            this.ReceiveAsync();
            this.btn_Daten.Enabled = false;
        }

        private async void ReceiveAsync()
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                Messwerte messwerte = new Messwerte(DateTime.Now, double.Parse(Encoding.UTF8.GetString(result.Buffer).Replace(".", ",")));
                this.txt_akt_Temp.Text = Encoding.UTF8.GetString(result.Buffer);
                werte.Add(messwerte);
                double sum = 0;
                foreach (Messwerte messung in werte)
                {
                    if(DateTime.Now.Subtract(new TimeSpan(0, 5, 0)) >= messung.Zeit)
                    {
                        werte.Remove(messung);
                    }
                    sum += messung.Messwert;
                }
                this.txt_mitt_Temp.Text = (sum / werte.Count).ToString("0.00");
            }
        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {

        }
    }
}