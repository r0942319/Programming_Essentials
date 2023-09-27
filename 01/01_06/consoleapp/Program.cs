Console.Write("Geef je lengte: ");
int Lengte = int.Parse(Console.ReadLine());

Console.Write("Geef je polsomtrek");
int Polsomtrek = int.Parse(Console.ReadLine());

// M = (L + 4 * P - 100) / 2

int gewicht = (Lengte + 4 * Polsomtrek) / 2;

Console.Write($"Ideaal gewicht: {gewicht} kilo");