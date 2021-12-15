using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1_Vorkommen
{
    class AnalyseText
    {
        public static void analyse(string text, string suchbegriff)
        {
            string[] textAr = text.Split(suchbegriff);
            Console.WriteLine(textAr.Length - 1);
        }
    }
}
