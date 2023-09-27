
Console.WriteLine("Kies een getal");

double getal = double.Parse(Console.ReadLine());

Console.WriteLine("Kies btw");

double btw = double.Parse((Console.ReadLine()));

double totaal = getal + (getal / 100 * btw);

Console.WriteLine($"Prijs inclusief BTW: {totaal}");

