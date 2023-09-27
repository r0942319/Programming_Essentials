double Volwassentot, kinderentot;
double prijsvol, prijskind;

prijsvol = 10;
prijskind = 7.50;

Console.WriteLine("hoeveel volwassenen");

Volwassentot = int.Parse(Console.ReadLine());

Console.WriteLine("Hoeveel kinderen onder 12");
kinderentot = int.Parse(Console.ReadLine());

double totaal = (Volwassentot * prijsvol) + (kinderentot * prijskind);
Console.WriteLine($"Totaal te betalen: {totaal}");
