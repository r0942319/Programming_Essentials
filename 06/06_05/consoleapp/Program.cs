//Lees namen en scores van studenten in. Wanneer een lege naam ingegeven wordt, zal er een overzicht afgeprint worden van alle studenten en hun scores gevolgd door een gemiddelde van de klas.
//Wanneer er geen namen ingegeven wordt, zal de tekst 'Geen aanwezigen' getoond worden.
//Zorg voor gegevensvalidatie wanneer er een score wordt ingegeven: dit moet een numerieke waarde zijn.

string naam, invoer;
int score;
bool isGeldig;


do
{
    Console.WriteLine("Wat is uw naam");
    naam = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(naam));




do
{
    Console.WriteLine("Wat is uw score");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out score);
} while (!isGeldig);



