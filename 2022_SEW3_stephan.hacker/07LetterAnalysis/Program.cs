using System;
using System.Collections.Generic;

namespace _07LetterAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wir wollen eine Häufigkeitsanalyse der Buchstaben in einem Text erstellen.

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            Console.Write("Bitte einen Text eingeben: ");
            string text = Console.ReadLine();
            text = text.ToLower();      //Gesamter Text in Kleinbuchstaben umwandeln

            for(int i = 0; i < text.Length; i++)        //läuft solange bis alle buchstaben durch sind
            {
                char letter = text[i];      //char --> Datentyp für 1 Buchstaben
                if(frequency.ContainsKey(letter))
                {
                    frequency[letter] += 1;
                }else
                {
                    frequency[letter] = 1;
                }
            }

            foreach(KeyValuePair<char, int> element in frequency)       //jeder Eintrag im Dictionary wird zu einem KeyValuePair
            {
                Console.WriteLine(element.Key + ": " + element.Value);  //key: Buchstabe, value: int (Häufigkeit)
            }
        }
    }
}
