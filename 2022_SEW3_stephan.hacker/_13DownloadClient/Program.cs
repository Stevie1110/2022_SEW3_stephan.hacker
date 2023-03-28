using _13DownloadClient;

List<Uri> urls = new List<Uri>();
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"));
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_abap"));
urls.Add(new Uri("http://bit.ly/leseprobe_schroedinger_html5"));
urls.Add(new Uri("http://bit.ly/leseprobe_programmieren_lernen"));
urls.Add(new Uri("http://www.thecodingguys.net/resources/cs-cheat-sheet.pdf"));

List<Task> tasks = new List<Task>();
//Task[] tasks = new Task[urls.Count];
foreach(Uri url in urls)
{
    // url downloaden
    PdfDownloader downloader = new PdfDownloader();
    downloader.DownloadFinished += DownloaderFinished;
    Task t = downloader.DownloadAsync(url);
    tasks.Add(t);
    //t.Wait();       //warten bis download fertig ist
    // durch den asynchronen Aufruf wird der Code an dieser Stelle weiter ausgeführt
}

Task.WaitAll(tasks.ToArray());        // warten bis alle tasks fertig sind

void DownloaderFinished(object? sender, PdfDownloadEventArgs e)
{
    Console.WriteLine("Downloader has finished file: " + e.FileName);
}