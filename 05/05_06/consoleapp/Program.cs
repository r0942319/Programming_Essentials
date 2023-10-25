bool isGeldig;
string invoer;
int getal, gok;
int aantalgokken;

do
{
    Console.Write("Geef een getal");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out getal) && getal <= 100;
} while (!isGeldig);

Console.WriteLine($"Je kan gokken van {getal - 5} tot {getal + 5}");

do
{
    aantalgokken++;
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out gok) && getal <= gok;

} while (!isGeldig);
Console.WriteLine($"Je had {aantalgokken}");