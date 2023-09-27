//Lees 2 getallen in. Deel het eerste getal door het tweede getal. Houd rekening met delen door 0.
//Indien dit het geval is, toon je “... is niet deelbaar door 0.”
int getal1;
int getal2;
int berekening = 0;




Console.WriteLine("geef 2 getallen");
getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());





if (getal2 == 0)
{
    Console.WriteLine($"{getal1} is niet deelbaar door 0.");
}
else
{
     berekening = getal1 / getal2;
     Console.WriteLine(getal1 + " / " + getal2 + " = " + berekening);
}
