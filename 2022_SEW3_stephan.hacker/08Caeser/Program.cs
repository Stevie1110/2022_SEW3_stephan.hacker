using System;

namespace _08Caeser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstelle eine Klasse Caesar, in dieser Klasse eine statische Methode

            //public string generateChiffre(string text, int key)



            string text = ("Ich bin einer kurzer aber geheimer Text");

            string chiffre = Caesar.generateChiffre(text, 300);

            Console.WriteLine(chiffre);

            text = Caesar.generateText(chiffre, 300);

            Console.WriteLine(text);
        }
    }
}
