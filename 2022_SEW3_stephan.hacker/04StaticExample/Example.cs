using System;
using System.Collections.Generic;
using System.Text;

namespace _04StaticExample
{
    class Example
    {
        private int highScore = 0;                      //existiert pro Objekt
        private static int lowScore = 0;                //existiert nur einmal pro Klasse
        public void doSomething()
        {
            Console.WriteLine("Ich bin eine nichtstatische Methode.");
            this.highScore = 100;
        }

        public static void doSomethingElse()
        {
            Console.WriteLine("Ich bin eine statische Methode.");
            Example.lowScore = -100;
        }
    }
}
