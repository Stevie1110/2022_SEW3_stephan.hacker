using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _13DownloadClient
{
    internal class PdfDownloader
    {
        public event EventHandler<PdfDownloadEventArgs> DownloadFinished;
        public async Task DownloadAsync(Uri url)
        {
            using(WebClient client = new WebClient())       //nach dem using Block, werden Ressourcen des WebClient wieder freigegeben
            {
                string pdfName = url.Segments.Last() + ".pdf";
                Console.WriteLine("Download: "+ pdfName);
                string fileName = @"C:\DEV\" + pdfName;

                await client.DownloadFileTaskAsync(url, fileName);      //nach diesem Aufruf wird der Code nach dem Aufruf der Methode download ausgeführt

                // diese Codezeilen werden erst ausgeführt, wenn der asynchrone Aufruf fertig ist
                Console.WriteLine("Download completed");
                if(this.DownloadFinished != null)
                {
                    PdfDownloadEventArgs args = new PdfDownloadEventArgs();
                    args.FileName = fileName;
                    DownloadFinished(this, args);
                }
            }
        }
    }
}
