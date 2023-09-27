//Er worden 3 getallen ingelezen en een code.

//Als de code 'A' of 'a' is, berekenen we de som van de 3 getallen.
//Als de code 'B' of 'b' is, berekenen we het product van het 1ste getal met het 3de getal.
//Als de code 'C' of 'c' is, berekenen we het verschil tussen het 3de getal en het 2de getal.

//Als de code 'D' of 'd' is, berekenen we de vierkantswortel van het 1ste getal als dit 1ste getal groter is dan nul.
//Als dit kleiner is dan 0, drukken we "Foutieve invoer.".
//In het geval van een andere code bepalen we het grootste getal uit de 3 ingevoerde getallen.

int resultaat = 0;
int resultaat2 = 0;
int resultaat3 = 0;
double resultaat4 = 0;

string code = "";
int cijfer1;
int cijfer2;
int cijfer3;
int maxnummer;

Console.WriteLine("Geef 3 getallen");
cijfer1 = int.Parse(Console.ReadLine());
cijfer2 = int.Parse(Console.ReadLine());
cijfer3 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef een code");
code = Console.ReadLine();

switch (code.ToLower()) //kan gebruikt worden als een if
{
    case "a":
        resultaat = cijfer1 + cijfer2 + cijfer3;
        Console.WriteLine($"Uitkomst: {resultaat}");
        break;
    case "b":
        resultaat2 = cijfer1 * cijfer3;
        Console.WriteLine($"Uitkomst: {resultaat2}");
        break;
    case "c":
        resultaat3 = cijfer3 - cijfer2;
        Console.WriteLine($"Uitkomst: {resultaat3}");
        break;
    case "d":
        resultaat4 = Math.Sqrt (cijfer1);
        Console.WriteLine($"Uitkomst: {resultaat4}");
        if (cijfer1 < 0)
        {
            Console.WriteLine("Foutieve invoer.");
        }
        break;
    default:
        maxnummer = Math.Max(cijfer1, Math.Max (cijfer2, cijfer3));
        Console.WriteLine($"Uitkomst: {maxnummer}");
        break;

}