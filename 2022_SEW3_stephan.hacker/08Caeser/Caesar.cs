using System;
using System.Collections.Generic;
using System.Text;

namespace _08Caeser
{
    class Caesar
    {
        public static string generateChiffre(string text, int key)

        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPRSTUVWKYZ";
            string result = "";

            //Überlegung: ..., -104, -52, 2, 54, 106, ...       alle diese Schlüssel liefern das gleiche Ergebnis

            while (key < 0)
            {
                key += alphabet.Length;        // solange Länge des Alphabets dazurechnen
            }

            foreach (char c in text)
            {
                if (alphabet.Contains(c))
                {
                    int indexOfChar = alphabet.IndexOf(c);
                    int indexOfNEewChar = (indexOfChar + key) % alphabet.Length;
                    char newChar = alphabet[indexOfNEewChar];
                    result += newChar;
                }
                else
                {
                    result += c;            //Sonderzeichen und Leerzeichen unveränder
                }
            }
            return result;
        }



        public static string generateText(string chiffre, int key)
        {
            return Caesar.generateChiffre(chiffre, key * -1);
        }
    }
}
