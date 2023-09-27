Console.Write("Geef een getal");
int getal = int.Parse(Console.ReadLine());
string result1 = "", result2 = "";
getal++;

/*oplossing 1 */
for (int i = 0; i < 10; i++)
{
    result1 += $"{i + getal}\n";
}
Console.WriteLine(result1);


/*oplossing 2 */
for (int i = getal; i < getal + 10; i++)
{
    result2 += $"{i}\n";
}

Console.WriteLine(result2);