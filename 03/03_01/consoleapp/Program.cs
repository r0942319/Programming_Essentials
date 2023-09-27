//Er moeten 3 gehele getallen ingelezen worden, één lettercode 'A' of 'B' en een cijfercode '1', '2' of '3'.
//De combinatie van de lettercode en de cijfercode bepalen welke bewerking er moet uitgevoerd worden. -> met de 3 ingelezen getallen.
//Bekijk onderstaande tabel aandachtig om de juiste bewerking te achterhalen.

int Cijfercode;
int Cijfer1;
int Cijfer2;
int Cijfer3;
string Lettercode;
string letter = "";

Console.WriteLine("Geef je eerste getal");
Cijfer1 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef je tweede getal");
Cijfer2 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef je derde getal");
Cijfer3 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef een lettercode A of B");
Lettercode = Console.ReadLine();

Console.WriteLine("Geef een cijfercode 1, 2 of 3");
Cijfercode = int.Parse(Console.ReadLine());


int resultaat = 0;
string tekst = "";

if ((Lettercode == "A"))

{
    if (Cijfercode == 1)
    {
        resultaat = Cijfer1 + Cijfer2;
        tekst = ($"{Cijfer1} + {Cijfer2}");
    }
    if (Cijfercode == 2)
    {
        resultaat = Cijfer2 + Cijfer3;
        tekst = ($"{Cijfer2} + {Cijfer3}");
    }
    if (Cijfercode == 3)
    {
        resultaat = Cijfer1 + Cijfer3;
        tekst = ($"{Cijfer1} + {Cijfer3}");
    }
}
if ((Lettercode == "B"))
{
    if (Cijfercode == 1)
    {
        resultaat = Cijfer1 - Cijfer2;
        tekst = ($"{Cijfer1} - {Cijfer2}");
    }
    if (Cijfercode == 2)
    {
        resultaat = Cijfer2 - Cijfer3;
        tekst = ($"{Cijfer2} - {Cijfer3}");
    }
    if (Cijfercode == 3)
    {
        resultaat = Cijfer1 - Cijfer3;
        tekst = ($"{Cijfer1} - {Cijfer3}");
    }
}

Console.WriteLine($"{tekst} = {resultaat}");