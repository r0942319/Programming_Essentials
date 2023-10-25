//Vraag de gebruiker om een tafel in te geven. Hij kan dit blijven doen tot het getal 0 wordt ingegeven.
//Op de input van de gebruiker wordt gegevenscontrole toegepast. Dit moet een numerieke waarde zijn.

//Indien de gebruiker meteen 0 ingeeft, stopt de applicatie en is er dus ook geen output.
//Indien de gebruiker enkele getallen ingeeft, tonen we van elk ingegeven getal de tafel van 10.


int tafel, uitkomst;
bool isGeldig;
string invoer;

while (true)

{
    Console.WriteLine("geef een nummer van 1 tot 10");
    if (!int.TryParse(Console.ReadLine(), out uitkomst))
    {
        Console.WriteLine("Foute input");
        continue;
    }

    if (uitkomst == 0)
    {
        
        break;
    }
    Console.WriteLine("kweeni");

    for (int i = 1; i < 10; i++)
    {
        Console.WriteLine($"{i} x {uitkomst} = {uitkomst * i}");
    }
}

//1 x 4 = 4.
