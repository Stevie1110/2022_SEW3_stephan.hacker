using System;
using System.Collections.Generic;

namespace _06Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>(); // Dictionary mit Key: String, Value: string

            myDict["Haus"] = "hause";
            myDict["Küche"] = "kitchen;";
            myDict["Dach"] = "roof;";

            Console.Write("Deutsch-Englisch Übersetzer: Bitte Wort eingeben: ");
            string input = Console.ReadLine();
            if(myDict.ContainsKey(input))
            {
                Console.WriteLine("Deutsch: " + input + " Englisch: " + myDict[input]); // myDict[input] --> liefert Wert , der unter diesem Schlüssel gespeichert ist
            }
            else
            {
                Console.WriteLine("Das Wort wurde nicht gefunden!");
            }

            Dictionary<int, string> pupils = new Dictionary<int, string>();
            pupils[1] = "Eigner";
            pupils[2] = "Forster";
            pupils[3] = "Führer";
            pupils[4] = "Gerschlager";

            Random rand = new Random();
            int nr = rand.Next(1, 5);
            Console.WriteLine("Zur Stundenwiederholung: " + pupils[nr]);    //ContainsKey nicht notwendig, weil alle möglichen Schlüssel vorhanden

            // geschachteltes Dictionary
            Dictionary<string, List<string>> telefonbuch = new Dictionary<string, List<string>>();
            telefonbuch["Thomas Riegler"] = new List<string>();
            telefonbuch["Thomas Riegler"].Add("0664....");
            telefonbuch["Benedikt Hager"] = new List<string>();
            telefonbuch["Benedikt Hager"].Add("0676....");
            telefonbuch["Benedikt Hager"].Add("0660....");

            Console.Write("Bitte Name eingeben: ");
            string name = Console.ReadLine();
            if(telefonbuch.ContainsKey(name))
            {
                foreach (string number in telefonbuch[name])     // telefonbuch[name] liefert die Liste der Nummeern
                {
                    Console.WriteLine(number);
                }
            } else
            {
                    Console.WriteLine("Kein Eintrag unter: " + name + " gefunden");
            }
        }
    }
}
