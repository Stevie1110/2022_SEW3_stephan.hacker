using _2_2_PrimeFactors;
using System;

PrimeNumber primzahl = new PrimeNumber();
primzahl.PrimeFactorFound += consolePrim;
primzahl.GeneratePrimeFactorsAsync(275);

PrimeNumber primzahl2 = new PrimeNumber();
primzahl2.PrimeFactorFound += (primnum) => 
Console.WriteLine("Wir haben einen Primfaktor für Sie gefunden: " + primnum);
primzahl2.GeneratePrimeFactorsAsync(275);

void consolePrim(int primnum)
{

    Console.WriteLine("Wir haben einen Primfaktor für Sie gefunden: " + primnum);
}