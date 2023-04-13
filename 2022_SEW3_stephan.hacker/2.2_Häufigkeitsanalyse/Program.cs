using System;
using System.Collections.Generic;

namespace _2._2_Häufigkeitsanalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCount test = new WordCount();
            Dictionary<string, int> a = new Dictionary<string, int>();
            a.Add("der", 0);
            a.Add("die", 0);
            a.Add("in", 0);
            a.Add("sein", 0);
            a.Add("und", 0);
            a.Add("ein", 0);
            a.Add("zu", 0);
            a.Add("von", 0);
            a.Add("haben", 0);
            test.MyWords(a);
            string path = "C:\\Users\\Stephan Hacker\\OneDrive - HBLFA Francisco Josephinum\\Dokumente\\SEW22_23\\FrequencyAnalysis";
            test.frequencyAnalysisOfFile(path);
            Console.WriteLine(test.ToString());
        }
    }
}
