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
                Console.WriteLine("Die Datei gibt es ja gar nicht.");
            }catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Der Ordner zur Datei existiert nicht.");
            }catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Der Zugriff auf die Datei wurde verweigert.");
            }catch(Exception ex)
            {
                Console.WriteLine("Hoppala. Da ist etwas ganz komisches passiert.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
