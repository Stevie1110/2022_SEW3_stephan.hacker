using System;
using System.Collections.Generic;
using System.Text;

namespace _09InversionChiffre
{
    class InversionChiffre
    {
        public static string generateChiffre(string text)
        {
            text = text.Trim();              //entfernen von Leerzeichen am Beginn und am Ende
            string[] split = text.Split(" ");                      // (" ")ist ein string aber mit (' ') ist es ein char-> ändert nix am Ergebnis
            //Array mit den einzelnen Worten
            string ret = "";

            foreach (string word in split)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    //"nur mehr" das Wort umdrehen
                    //z.B. "Hallo"
                    for (int i = word.Length - 1; i >= 0; i--)
                    {
                        //Schleife von oben nach unten zählen
                        ret += word[i];
                    }
                    ret += " ";     //Leerzeichen nach jedem Wort
                }
            }
            return ret;

        }
    }
}
