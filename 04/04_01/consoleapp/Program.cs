//Schrijf een programma dat 10 getallen inleest. Bereken de som van deze 10 getallen en druk deze af.
//Natuurlijk kan het zijn dat we in de toekomst 20 getallen of slechts 5 getallen willen inlezen. Programmeer dit dus zo efficiënt mogelijk.

int getal;
int resultaat = 0;


for (int i = 0 ; i < 10; i++) // for loop die 10 keer herhaalt
{
    Console.WriteLine("geef een getal: ");
    getal = int.Parse(Console.ReadLine());//leest een getal 10 keer af
    resultaat += getal;
}

Console.WriteLine($"Som: {resultaat}");