//Lees een positief getal in. Daarna wordt het kwadraat van dat getal getoond, gevolgd door het kwadraat van het getal verminderd met 1.
//Herhaal dit tot je eindigt met het kwadraat van 1.


Console.WriteLine("Geef een getal:");
int getal = int.Parse(Console.ReadLine());
string resultaat = "";

for (int i = getal; i >= 1 ; i--)
{
    int kwadraad = i * i;
    resultaat += $"{kwadraad}\n";
}
Console.WriteLine(resultaat);
