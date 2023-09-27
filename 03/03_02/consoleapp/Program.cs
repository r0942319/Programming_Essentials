//Bepaal of een ingevoerd jaartal een schrikkeljaar is of niet. Doe dit aan de hand van onderstaande regels:

//Voor de jaren na 1582 geldt volgende regeling:

//Deelbaar door 4000 = geen schrikkeljaar
//Deelbaar door 400 = wel schrikkeljaar
//Deelbaar door 100 = geen schrikkeljaar
//Deelbaar door 4 = wel schrikkeljaar
//Voor de jaren voor 1582 geldt de regel dat als ze deelbaar zijn door 4 het jaar een schrikkeljaar is.

//Voor de jaren na 1582 mag je stoppen met controleren wanneer er aan één voorwaarde voldaan is.
//Dit wilt zeggen dat als een jaar deelbaar is door 4000, het sowieso geen schrikkeljaar is, ongeacht de andere voorwaarden.

using System.ComponentModel.Design;
string uitvoer = "";
int resultaat;
int Jaartal;

Console.WriteLine("Geef een jaartal");
Jaartal = int.Parse(Console.ReadLine());

if (Jaartal < 1582)
{
    if (Jaartal % 4 == 0)
    {
        //wel
        uitvoer = "een schrikkeljaar";
    }
    else
    {
        //niet
        uitvoer = "geen schrikkeljaar";
    }
}
else
{
    if (Jaartal % 4000 == 0)
    {
        //geen
        uitvoer = "geen schrikkeljaar";
    }
    else if (Jaartal % 400 == 0)
    {
        //geen
        uitvoer = "een schrikkeljaar";
    }
    else if (Jaartal % 100 == 1)
    {
        uitvoer = "geen schrikkeljaar";
    }
    else if (Jaartal % 4 == 0)
    {
        uitvoer = "een schrikkeljaar";
    }
    else
    {
        uitvoer = "geen schrikkeljaar";
    }
}

Console.WriteLine($"Uw jaartal is {Jaartal}");
Console.WriteLine($"Uw getal is {uitvoer}");
Console.WriteLine($"{Jaartal} is {uitvoer}");