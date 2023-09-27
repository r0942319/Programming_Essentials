// Lees 2 getallen in.
// We veronderstellen dat het eerste getal groter is dan het tweede getal. Geef alle getallen die tussen het eerste en het tweede getal liggen.
int getal1;
int getal2;

Console.WriteLine("Geef 2 getallen");
getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());


for (int i = getal1; i >= getal2; i--)
{
    Console.Write($"{i} * ");
}
