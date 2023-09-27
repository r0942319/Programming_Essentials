// Lees 2 symbolen in. Na het inlezen van deze symbolen vraag je een lengte en een breedte.
// Hierna drukt het programma een sjaal af met de ingevoerde waarden. Bekijk de voorbeelden aandachtig.

using System;

string symbool;
string symbool2;
int lengte;
int breedte;

Console.WriteLine("Geef 2 symbolen");
symbool = Console.ReadLine();
symbool2 = Console.ReadLine();
Console.WriteLine("Wat is de lengte");
lengte = int.Parse (Console.ReadLine());
Console.WriteLine("Wat is de breedte");
breedte = int.Parse (Console.ReadLine());


Console.WriteLine($"uw symbolen zijn {symbool} en {symbool2}");
Console.WriteLine($"uw lengte is {lengte}, breedte is {breedte}");

for (int i = 0; i < lengte; i++)
{
    for (int j = 0; j < breedte; j++)
    {
        string huidigsymbool = (i % 2 == 0) ? symbool : symbool2;
        Console.Write(huidigsymbool);
    }
    Console.WriteLine();
}