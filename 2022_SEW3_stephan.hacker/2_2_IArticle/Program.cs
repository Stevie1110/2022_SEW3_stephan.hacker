using _2_2_IArticle;
using System.Drawing;

List<IArticle> ware = new List<IArticle>();
ware.Add(new Book(10.60, "Schnitzelbuch"));
ware.Add(new Smartphone(820, "Samsung Galaxy s7"));
ware.Add(new Book(17.99, "Kochbuch"));
ware.Add(new Smartphone(1225.99, "Iphone 12"));


double summe = 0;
ware.ForEach(x => summe += x.Price);
Console.WriteLine("Ihre Gesamtsumme des Einkaufs beträgt: " + summe);
