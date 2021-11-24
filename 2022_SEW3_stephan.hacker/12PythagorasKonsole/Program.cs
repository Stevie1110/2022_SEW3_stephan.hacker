using System;
using _11Pythagoras;

namespace _12PythagorasKonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double hypo = Pythagoras.calculateHypothenuse(4, 5);
            Console.WriteLine("Die Hypothenuse des rechtwinkeligen Dreiecks mit den Katheten 4.0 und 5.0 beträgt: {0:f2}", hypo);

            double umfang = Pythagoras.calculateCircumstance(1, 12, 10);
            Console.WriteLine("Der Umfang beträgt: {0:f0}", umfang);
            //Berechne den Umfang des Dreiecks mit den Kantenlängen 1,2 und 10
            //Formatiere die Ausgabe auf 0 Nachkommastellen

            double fläche = Pythagoras.calculateAreaKK(4, 5);
            Console.WriteLine("Die Fläche beträgt: {0:f1}", fläche);
            //Berechne die Fläche des Dreiecks, 4 und 5
            //Formatiere Ausgabe auf 1 Nachkommastelle
        }
    }
}
