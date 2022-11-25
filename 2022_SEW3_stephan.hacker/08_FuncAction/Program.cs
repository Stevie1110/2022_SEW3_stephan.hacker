
//gleiches Beispiel wie 05Delegates nur mit generischen Datentypen (Func, Action)

static int Addition(int x, int y)
{
    return x + y;
}

static int Substraction(int x, int y)
{
    return x - y;
}

static int Multiplication(int x, int y)
{
    return x * y;
}
static void PrintWithLeadingSpaces(int x)
{
    Console.WriteLine("    " + x);
}

static void PrintWithLeading0(int x)
{
    Console.WriteLine("0000" + x);
}


Func<int, int, int> operation = new Func<int, int, int>(Addition);          //neues generischesFunc-Delegate

int result = operation(4, 5);
Console.WriteLine("Ergebnis: " + result);

operation = new Func<int, int, int>(Substraction);
result = operation(4, 5);
Console.WriteLine("Ergebnis: " + result);


operation = Multiplication;             //kurze Sschreibweise einer Zuweisung zu einem delegate
result = operation(4, 5);
Console.WriteLine("Ergebnis: " + result);

Action<int> printer = PrintWithLeadingSpaces;
printer(99);
Console.WriteLine("---------");
printer += PrintWithLeading0;       //weitere zusätzliche Methode zuweisen
printer(66);
Console.WriteLine("---------");
printer -= PrintWithLeadingSpaces;
printer(55);
printer -= PrintWithLeading0;           //alle Methoden wurden abgemeldet --> printer ist null
printer(44);
if (printer != null)
{
    printer(44);
}