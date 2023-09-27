// Schrijf een programma dat de naam van de gebruiker inleest en zijn geluksgetal.
// Druk nu het geluksgetal af gevolgd door x-aantal keer de ingelezen naam. X-aantal keer wordt bepaald door het ingevoerde geluksgetal.

int geluksgetal;
string voornaam;


Console.WriteLine("wat is uw voornaam?");
voornaam = Console.ReadLine();

Console.WriteLine("wat is uw geluksgetal?");
geluksgetal = int.Parse(Console.ReadLine());


Console.Write(geluksgetal +" ");

for (int i = 0; i < geluksgetal; i++)
{
    Console.Write($"{voornaam} ");
}