using System;
using System.Collections.Generic;
using System.Text;

namespace _05Generics
{
    class AverageCalculator
    {
        public static double AverageOfInput()
        {
            Console.WriteLine("Ich berechne den Mittelwert der eingegebenen Zahlen. Beliebiges Zeichen für Ende der Eingabe!");
            double inputValue;

            List<double> values = new List<double>();

            while (true)
            {
                //break; // unterbricht eine schleife
                Console.Write("Bitte ine Zahl eingeben");

                try
                {
                    inputValue = double.Parse(Console.ReadLine());
                    values.Add(inputValue); //.Add fügt ein Element am ende der Liste hinzu
                }
                catch (Exception)
                {
                    //nichts tun weil wir die Eingabe beenden wollen

                    double sum = 0.0;

                    foreach (double element in values)
                    {
                        sum += element;
                    }

                    if (values.Count > 0)
                    {
                        return sum / values.Count;
                    }
                    else
                    {
                        return 0.0;
                    }
                }
            }
        }
    }
}
