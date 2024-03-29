﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hue03
{
    internal class Count
    {
        Dictionary<string, int> myWords = new Dictionary<string, int>();

        public void MyWords(Dictionary<string, int> myWords)
        {
            this.myWords = myWords;
        }

        public void frequencyAnalysis(string text)
        {
            foreach (KeyValuePair<string, int> item in myWords)
            {
                string[] textAr = text.Split(item.Key);
                myWords[item.Key] = textAr.Length - 1;
            }
        }

        public void frequencyAnalysisOfFile(string pathToFile)
        {
            string text = System.IO.File.ReadAllText(pathToFile);
            foreach (KeyValuePair<string, int> item in myWords)
            {
                string[] textAr = text.Split(item.Key);
                myWords[item.Key] = textAr.Length - 1;
            }
        }

        public override string ToString()
        {
            string text = "Heufgkeitsanalyse:\n";
            foreach (KeyValuePair<string, int> item in myWords)
            {
                text = text + item.Key + " - " + item.Value + "\n";
            }
            return text;
        }
    }
}
