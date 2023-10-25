//Lees voor 5 artikelen de prijs in. Lees daarna het aantal jaren dat de klant lid is.
//Het maximum aantal jaren lid is ingesteld op 5 jaar. (erg belamgrijk) // Er wordt een korting toegekend volgens volgende regels:


//1 jaar lid: 5 euro korting op de totaalprijs.
//2 jaren lid: 10 euro korting op de totaalprijs.
//3 jaren lid: 20 euro korting op de totaalprijs.
//4 jaren lid: 30 euro korting op de totaalprijs.
//5 jaren lid: 50 euro korting op de totaalprijs.
//Toon de totaalprijs die klant moet betalen, zijnde de som van de prijzen van de artikelen, verminderd met de korting die de klant krijgt.
//(werk met cases voor de korting) for loop 1 tot 5 met cases van 1 tot 5 voor case 1 kan je korting toevoegen tot 5
string invoer;
bool isGeldig;
int korting, totaalprijs, Jaar;
int Artikel1, Artikel2, Artikel3, Artikel4, Artikel5;
int resultaat1, resultaat2, resultaat3, resultaat4, resultaat5;

//Thuis opzoeken hoe switch mafmaken.

do
{
    Console.WriteLine("Hoeveel kost artikel 1");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out Artikel1);
} while (!isGeldig);

do
{
    Console.WriteLine("Hoeveel kost artikel 2");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out Artikel2);
} while (!isGeldig);

do
{
    Console.WriteLine("Hoeveel kost artikel 3");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out Artikel3);
} while (!isGeldig);

do
{
    Console.WriteLine("Hoeveel kost artikel 4");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out Artikel4);
} while (!isGeldig);

do
{
    Console.WriteLine("Hoeveel kost artikel 5");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out Artikel5);
} while (!isGeldig);




do
{
    Console.WriteLine("Aantal jaren lid");
    invoer = Console.ReadLine();
    isGeldig = int.TryParse(invoer, out Jaar);
} while (!isGeldig);

totaalprijs = Artikel1 + Artikel2 + Artikel3 + Artikel4 + Artikel5;


for (int i = 1; i <= 5; i++)
{
    switch (i)
    {
        case 1:
            resultaat1 = totaalprijs - 5;
            Console.WriteLine($"Totaalprijs: {totaalprijs - 5} euro");
            break;
        case 2:
            resultaat2 = totaalprijs - 10;
            Console.WriteLine($"Totaalprijs: {totaalprijs - 10} euro");
            break;
        case 3:
            resultaat3 = totaalprijs - 20;
            Console.WriteLine($"Totaalprijs: {totaalprijs - 20} euro");
            break;
        case 4:
            resultaat4 = totaalprijs - 30;
            Console.WriteLine($"Totaalprijs: {totaalprijs - 30} euro");
            break;
        case 5:
            resultaat5 = totaalprijs - 50;
            Console.WriteLine($"Totaalprijs: {totaalprijs - 50} euro");
            break;
    }
     
}