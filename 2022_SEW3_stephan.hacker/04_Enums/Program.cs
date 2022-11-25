DayOfWeek startOfWeek = DayOfWeek.Monday;
Classes bestClassAtFJ = Classes._4IT;

Console.WriteLine("Beste Klasse des FJ: " + bestClassAtFJ);
Console.WriteLine("Beste Klasse des FJ: " + (int)bestClassAtFJ);
Console.WriteLine("Red: " + Color.Red);
Console.WriteLine("Red: " + (int)Color.Red);

public enum Classes { _1IT, _2IT, _3IT, _4IT, _5IT};

public enum Color {  Red= 16711680, Green=65280, Blue=255}      // Red: 255 0 0, #FF0000  Green: 0 255 0, #00FF00
