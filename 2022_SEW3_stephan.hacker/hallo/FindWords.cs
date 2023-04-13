using System;
using System.Collections.Generic;
using System.Text;

namespace _hallo
{
    class FindWords
    {
        static public List<string> find(string text, char zeichen)
        {
            List<string> words = new List<string>();


            int temp = 0;
            while (true)
            {
                string tempWord = "";
                temp = text.IndexOf(zeichen, temp + 1);
                if (text.IndexOf(zeichen, temp + 1) != -1)
                {
                    for (int i = temp + 1; i < text.IndexOf(zeichen, temp + 1); i++)
                    {
                        tempWord += text[i];
                    }
                    words.Add(tempWord);
                    temp = text.IndexOf(zeichen, temp + 1);
                }
                else
                {
                    break;
                }
            }

            return words;
        }
    }
}