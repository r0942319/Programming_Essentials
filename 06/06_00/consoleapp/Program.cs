int getal, som = 0;
string invoer;
bool isGeldig;

//PR 1 Stap 1: lees de kritieke waarde 			(PR1)
//Lees de waarde die ervoor zorgt dat het programma al dan niet stopt.

do
{
    Console.Write("Geef een getal:");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out getal);
} while (!isGeldig);


//PR 2  Stap 2: controleer de kritieke waarde 		(PR2)
//Kritieke waarde != stopwaarde ?

while (getal > 0)
{
    //PR 3 Stap 3: werk de instructies uit die moeten 	(PR3)            herhaald worden

    som += getal;


    // PR4 Stap 4: lees de volgende kritieke waarde 
    do
    {
        Console.Write("Geef nog een getal:");
        invoer = Console.ReadLine();
        isGeldig = int.TryParse(invoer, out getal);
    } while (!isGeldig);
}

Console.WriteLine($"Som: {som}");