using System;
using System.Collections.Generic;
using System.Text;

namespace _01Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle puch = new Motorcycle("Puch 500");
            Driver stephan = new  ;
            Console.WriteLine(driver);

            Driver driver = new Driver("Stephan Hacker");
            CoDriver codriver = new CoDriver("Joan Mir");

            try
            {
                driver.MyMotorcycle = codriver;
                Console.WriteLine(driver);
            }
            catch (NotPossibleException)
            {
                Console.WriteLine("Falsche Person am Beifahrersitz");
            }
            finally
            {
                Console.WriteLine("Allzeit gute Fahrt!");
            }
        }
    }
}
