using System;

namespace _03TractorAndImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            Tractor fendt = new Tractor("Fendt 211", 4280, 7000);
            Implement cultivator = new Implement("Einböck Aerostar", 1750);
            Implement bogballe = new Implement("Bogballe M60W", 6000);

            Console.WriteLine(cultivator);
            Console.WriteLine(fendt);

            fendt.MyImplement = cultivator;
            Console.WriteLine(fendt);
            fendt.MyImplement = null;
            Console.WriteLine(fendt);
            try
            {
                fendt.MyImplement = bogballe;               //in dieser Zeile wird eventuell eine Exception geworfen.
                Console.WriteLine(fendt);
            }
            catch(ImplementTooHeavyException)
            {
                Console.WriteLine("Dieses Gerät überschreitet das maximale Gewicht.");
            } 
        }
    }
}
