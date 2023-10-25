string symbool, symbool2, invoer;
int lengte, breedte;
bool isGeldig;
string stopwoord = "*****";


do
{
    do
    {
        Console.WriteLine("Geef 2 symbolen");
        symbool = int.Parse(Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(symbool));
} while (symbool > 4);

do
{
    symbool2 = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(symbool2));


do
{
    Console.WriteLine("Wat is de lengte");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out lengte);
} while (!isGeldig);


do
{
    Console.WriteLine("Wat is de breedte");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out breedte);
} while (!isGeldig);


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