using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hue02
{
    internal class chatbot
    {
        public void StartChat() {
            Console.WriteLine("Herzlich Willkommen im Chat - Sie können den Chat jederzeit mit dem Wort bye beenden");
            string benutzereingabe = Console.ReadLine();

            Dictionary<string, string> german = new Dictionary<string, string>();
            Dictionary<string, string> english = new Dictionary<string, string>();

            List<string> list_g = new List<string>();
            List<string> list_e = new List<string>();

            string datenbasis = @"C:\Users\Stephan Hacker\OneDrive - HBLFA Francisco Josephinum\Dokumente\SEW22_23\hue02\datenbasis.txt";
            string database = @"C:\Users\Stephan Hacker\OneDrive - HBLFA Francisco Josephinum\Dokumente\SEW22_23\hue02\database.txt";
            string zufallsantwort = @"C:\Users\Stephan Hacker\OneDrive - HBLFA Francisco Josephinum\Dokumente\SEW22_23\hue02\zufallsantwort.txt";
            string randomanswer = @"C:\Users\Stephan Hacker\OneDrive - HBLFA Francisco Josephinum\Dokumente\SEW22_23\hue02\randomanswer.txt";

            string[] answers_db = System.IO.File.ReadAllLines(datenbasis);
            string[] answers_dbe = System.IO.File.ReadAllLines(database);
            string[] answers_zufall = System.IO.File.ReadAllLines(zufallsantwort);
            string[] answers_random = System.IO.File.ReadAllLines(randomanswer);


            for (int i = 0; i < 5; i++)
            {
                int x = 0;
                string[] splits = answers_db[i].Split(':');
                german.Add(splits[x], splits[x + 1]);
                x = x + 2;
            }

            for (int i = 0; i < 5; i++)
            {
                int x = 0;
                string[] splits = answers_dbe[i].Split(':');
                english.Add(splits[x], splits[x + 1]);
                x = x + 2;
            }

            for (int i = 0; i < 5; i++)
            {
                list_g.Add(answers_zufall[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                list_e.Add(answers_random[i]);
            }

            Console.WriteLine("Which Language do you want to use? - Welche Sprache möchten Sie wählen");
            string language = Console.ReadLine();
            if(language == "english")
            {
                string input = "";
                Console.WriteLine("Start the Chat: ");
                while(input != "bye")
                {
                    bool in_correct = false;
                    input = Console.ReadLine();
                    string[] inputsplit = input.Split(' ');
                    foreach(string word in inputsplit)
                    {
                        foreach(string word2 in english.Keys)
                        {
                            if (word == word2)
                            {
                                string ausgabe = english[word2];
                                Console.WriteLine(ausgabe);
                                in_correct = true;
                                break;
                            }
                        }
                        if (in_correct)
                        {
                            break;
                        }
                    }
                    if (!in_correct)
                    {
                        Random rnd = new Random();
                        int zahl = rnd.Next(0, list_e.Count());
                        Console.WriteLine(list_e[zahl]);
                    }
                }
            }else if(language == "german")
            {
                string input = "";
                Console.WriteLine("Starten Sie den Chat: ");
                while (input != "bye")
                {
                    bool in_correct = false;
                    input = Console.ReadLine();
                    string[] inputsplit = input.Split(' ');
                    foreach (string wort in inputsplit)
                    {
                        foreach (string word2 in german.Keys)
                        {
                            if (wort == word2)
                            {
                                string ausgabe = german[word2];
                                Console.WriteLine(ausgabe);
                                in_correct = true;
                                break;
                            }
                        }
                        if(in_correct)
                        {
                            break;
                        }
                    }
                    if(!in_correct)
                    {
                        Random rnd = new Random();
                        int zahl = rnd.Next(0, list_g.Count());
                        Console.WriteLine(list_g[zahl]);
                    }
                }
            }
        }
    }
}
