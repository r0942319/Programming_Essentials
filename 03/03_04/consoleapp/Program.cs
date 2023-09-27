//Vraag naam en voornaam op van de gebruiker. Vraag daarna de hobby op van de gebruiker aan de hand van het bijhorende cijfer.
//Indien de gebruiker een verkeerde keuze maakt, krijgt hij/zij geen suggestie. Toon in dit geval een "-".

//Het programma drukt het bijpassende tijdschrift af. Let ook op de hoofdletters.
//Zoek op hoe je een bepaald woord volledig in hoofdletters of kleine letters kan zetten.
using System.Text.Json;

string naam;
string voornaam;
string hobby;
string tijdschrift;
tijdschrift = "";





Console.WriteLine("Wat is uw naam");
naam = Console.ReadLine().ToLower();

Console.WriteLine("Wat is uw voornaam");
voornaam = Console.ReadLine().ToUpper();



Console.WriteLine($"Uw volledige naam is {voornaam} {naam}");

Console.WriteLine("Wat is uw hobby?");
hobby = Console.ReadLine();

switch (hobby)
{
    case "1":
        hobby = "\"handwerk\"";
        tijdschrift = "\"Anna\"";
        break;
    case "2":
        hobby = "\"Kleding maken\"";
        tijdschrift = "\"Knippie\"";
        break;
    case "3":
        hobby = "\"Interieur\"";
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
        hobby = "\"Fotografie\"";
        tijdschrift = "\"Zoom NL\"";
        break;
    case "7":
        hobby = "\"Lopen\"";
        tijdschrift = "\"Runners\"";
        break;
    default:
        hobby = "-";
        tijdschrift = "-";
        break;
}

Console.WriteLine($"{naam} {voornaam}, tijdschrift: {tijdschrift}");