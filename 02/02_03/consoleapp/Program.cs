String voornaam;
String familienaam;
int leeftijd;


Console.WriteLine("wat is uw voornaam?");
voornaam = Console.ReadLine();

Console.WriteLine("wat is uw familienaam?");
familienaam = Console.ReadLine();

Console.WriteLine("wat is uw leeftijd?");
leeftijd = int.Parse (Console.ReadLine());

string message = leeftijd >= 18 ? "Volwassenen" : "Jeugd";

Console.WriteLine($"Thomas Proost: {message}");
Console.WriteLine($"Jan de Wit: {message}");
Console.WriteLine($"Joren Synaeve: {message}");
Console.WriteLine($"Jochem Peeters: {message}");  
Console.WriteLine($"Jef Nijs: {message}");
Console.WriteLine($"Stef Jansen: {message}");