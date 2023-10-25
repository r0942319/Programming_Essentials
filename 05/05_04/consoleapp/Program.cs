//De gebruiker krijgt een zin te zien om te onthouden.
//Namelijk 'Op de stoel ligt een zonnehoed en peperkoek'.
//Vervolgens kan deze op enter drukken om het spel te starten. /Thuis opzoeken hoe dit moet/ -> dit moet niet voor deze oefening
//Het scherm wordt leeggemaakt. /Thuis opzoeken hoe dit moet/ -> dit moet niet voor deze oefening

//Lees vervolgens de pogingen van de gebruiker om de zin te reproduceren in. Dit kan in 1 of meerdere keren gebeuren.

//Wanneer de gebruiker het woord raadt, zal weergegeven worden in hoeveel pogingen deze werd geraden.

string zin = "Op de stoel ligt een zonnehoed en peperkoek";
int pogingen = 0;
string invoer;
bool isGeldig;
string geradenZin;


    do
    {
        Console.WriteLine($"{zin}");
        invoer = Console.ReadLine();
        pogingen++;
    } while (!invoer.Equals(zin));


if (pogingen == 1)

Console.WriteLine($"Je had {pogingen} poging nodig!.");

else
{
    Console.WriteLine($"Je had {pogingen} pogingen nodig!.");
}
