using System;

namespace _10StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 1234;
            string s = "Hallo";
            double d = 3.14;
            float f = 99.99f;

            Console.WriteLine(string.Format("Hallo liebe Welt {0} {1}", i, f));
            Console.WriteLine("Der Artikel kostet {0:f2} Euro und ist in {1} Wochen lieferbar.", f, i);
            Console.WriteLine("8-stellige Artikelnummer ist: {0:d8}", j);
        }
    }
}
