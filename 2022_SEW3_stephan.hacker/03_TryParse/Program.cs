﻿Console.Write("Bitte eine ganze Zahl eingeben: ");
string input = Console.ReadLine();

//int number = int.Parse(input);  möglicherweise Fehler, wenn etwas anderes als Zahl eingegeben wird.

int number;
bool success = int.TryParse(input, out number);

if(success)
{
    Console.Write("Super, du hast eine Zahl eingegeben!");
}
else
{
    Console.WriteLine("Leider keine Zahl");
    //Eingaben wiederholen --> vermutlich in einer Schleife
}

//double.TryParse(..);
//bool.TryParse(..);
//... für alle value Types