using System;
using System.Collections.Generic;

namespace _hallo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Class1.find("Schlechte #Programmierer# sorgen sich um den Code. Gute #PROGRAMMIERER# sorgen sich um #Datenstrukturen# und ihre Beziehungen.", '#');
            foreach (string item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}