//Lees de familie- en voornaam van de gebruiker in. Controleer dat de invoer ingevuld is.

//Lees de hobby van de gebruiker in aan de hand van het bijhorende nummer. Hierbij wordt een tijdschrift suggestie getoond. Gebruik hiervoor onderstaande tabel.
//Vervolgens krijgt de gebruiker opnieuw de optie om een hobby in te geven.

//Het bovenstaande proces blijft gebeuren tot de gebruiker 8 ingeeft op de vraag welke hobby deze uitoefent.

//code thuis nog aanpassen klopt bijna


string familienaam, voornaam, tijdschrift;
string hobby, invoer;
bool isGeldig;
do
{
    Console.WriteLine("Wat is uw familienaam");
    familienaam = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(familienaam));

do

{
    Console.WriteLine("Wat is uw voornaam");
    voornaam = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(voornaam));


Console.WriteLine("Wat is uw hobby");
hobby = Console.ReadLine();



do
{
    Console.WriteLine("Wat is uw hobby");
    hobby = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(hobby));


    do
    {
        Console.WriteLine("Wat is uw hobby?");
        invoer = Console.ReadLine();
        isGeldig = int.TryParse(invoer, out hobby);
    } while (!isGeldig);






switch (hobby)
{
    case "1":
        hobby = "Wij raden \"Anna\" aan.";
        tijdschrift = "\"Anna\"";
        break;
    case "2":
        hobby = "\"Kleding maken\"";
        tijdschrift = "\"Knippie\"";
        break;
    case "3":
        hobby = "Wij raden 'VtWonen'aan.";
        tijdschrift = "\"VtWonen\"";
        break;
    case "4":
        hobby = "\"Voetballen\"";
        tijdschrift = "\"Voetbal International\"\'.";
        break;
    case "5":
        hobby = "\"Fietsen\"";
        tijdschrift = "\"Wandelen & fietsen\"";
        break;
    case "6":
        hobby = "Wij raden \"Zoom NL\" aan.";
        tijdschrift = "\"Zoom NL\"";
        break;
    case "7":
        hobby = "\"Lopen\"";
        tijdschrift = "\"Runners\"";
        break;
    case "8":
        hobby = "Wij raden niets aan";
        break;
}


    Console.WriteLine($"uw hobby is {hobby}");




