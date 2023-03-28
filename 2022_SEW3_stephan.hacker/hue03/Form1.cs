using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hue03
{
    public partial class Form1 : Form
    {
        private string ergebnisPath;
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateien_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datei_w�hlen_btn_Click(object sender, EventArgs e)
        {
            if (Ordner_w�hlen.ShowDialog() == DialogResult.OK)
            {
                filePath = Ordner_w�hlen.SelectedPath;
            }
        }

        private void speicherort_btn_Click(object sender, EventArgs e)
        {
            if (Speicherort.ShowDialog() == DialogResult.OK)
            {
                ergebnisPath = Speicherort.SelectedPath;
            }
        }

        

        public void frequencyAnalysisOfFile(string pathToFile)
        {
            string text = System.IO.File.ReadAllText(pathToFile);
            Dictionary<char, int> h�ufigkeit = new Dictionary<char, int>();
            foreach (char buchstabe in text)
            {
                if (h�ufigkeit.ContainsKey(buchstabe))
                {
                    h�ufigkeit[buchstabe]++;
                }
                else
                {
                    h�ufigkeit.Add(buchstabe, 1);
                }
            }
            string texth�ufigkeitdatei = "";
            foreach (KeyValuePair<char, int> kVp in h�ufigkeit)
            {
                texth�ufigkeitdatei += kVp.Key + " = " + kVp.Value.ToString() + "\r\n";
            }
            string pfad = ergebnisPath + "\\" + System.IO.Path.GetFileName(pathToFile);
            System.IO.File.WriteAllText(pfad, texth�ufigkeitdatei);
            WriteTextSafe(pathToFile);
            //dateien_tb.AppendText(System.IO.Path.GetFileName(pathToFile) + "\r\n");
        }

        public void WriteTextSafe(string pathToFile)
        {
            if (dateien_tb.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate {
                    WriteTextSafe($"{pathToFile}");
                };

                dateien_tb.Invoke(safeWrite);
            }
            else
                dateien_tb.AppendText(System.IO.Path.GetFileName(pathToFile) + "\r\n");
        }


        private async void analyse_btn_Click(object sender, EventArgs e)
        {
            string[] dateien = Directory.GetFiles(filePath);
            progressBar1.Maximum = dateien.Length;
            var tasks = new List<Task>();
            foreach (string datei in dateien)
            {
                tasks.Add(Task.Run(() =>frequencyAnalysisOfFile(datei)));
                progressBar1.Value++;
            }
            await Task.WhenAll(tasks);
        }
    }
}