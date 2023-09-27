//Lees 2 getallen in. Bereken het verschil tussen deze twee getallen, maar trek telkens het kleinste getal van het grootste af.

double resultaat;
double groot;
double klein;

Console.WriteLine("Geef 2 getallen");
double getal1 = double.Parse(Console.ReadLine());
double getal2 = double.Parse(Console.ReadLine());

if (getal1 > getal2)
{
    groot = getal1;
    klein = getal2;
    resultaat = groot - klein;
}
else
{
    groot = getal2;
    klein = getal1;
    resultaat = groot - klein;
}

Console.WriteLine($"{groot} - {klein} = {resultaat}");