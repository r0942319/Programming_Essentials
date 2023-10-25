int getal1, getal2,uitkomst;
string invoer;
bool isGeldig;



//Lees 2 getallen in. Bereken het verschil tussen deze twee getallen, maar trek telkens het kleinste getal van het grootste af.
//Wanneer een foute waarde ingevoerd wordt, zal er naar een nieuwe waarde gevraagd worden.

do
{
    Console.WriteLine("Geef een eerste getal");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out getal1);
} while (!isGeldig);


do
{
    Console.WriteLine("Geef een tweede getal");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out getal2);
} while (!isGeldig);


int verschil;

if (getal1 < getal2)
{
    verschil = getal2 - getal1;
    Console.WriteLine($"{getal2} - {getal1} = {verschil}");
}
else
{
    verschil = getal1 - getal2;
    Console.WriteLine($"{getal1} - {getal2} = {verschil}");
}