using System;
using System.IO;

namespace _02Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText(@"C:\DEV\myFile.txt");        // @ sorgt dafür, dass \ nicht als Formatierungszeichen gesehen wird.
                Console.WriteLine("Der Text in der Datei lautet:");
                Console.WriteLine(text);
            }catch(FileNotFoundException)
            {
                //hier gehts weiter nächste stunde
            }
        }
    }
}
