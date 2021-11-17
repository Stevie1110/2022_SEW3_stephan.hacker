using System;

namespace _09InversionChiffre
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren sie folgende Verschlüsselung
            //z.B.:
            //Machen Sie es gut
            //nehcaM eiS se tug!

            Console.Write("Bitte einen Text eingeben!");
            string text = Console.ReadLine();
            string result = InversionChiffre.generateChiffre(text);
            Console.WriteLine(result);
        }
    }
}
