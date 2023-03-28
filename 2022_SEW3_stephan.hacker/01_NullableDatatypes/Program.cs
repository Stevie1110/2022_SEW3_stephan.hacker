int i = 100;

int? j = null;          //noch keinen Wert zugewiesen
int k;

Console.WriteLine(j);

k = i * 100;

if (j.HasValue)                 //ungleich null
{
    k = j.Value * 100;
}

k = i * j.GetValueOrDefault() * 100;

j = null;

string s = null;
string? s2 = null;