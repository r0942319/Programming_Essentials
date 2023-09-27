//Schrijf een programma dat het aantal graden Celsius opvraagt. Bereken en toon het aantal graden Fahrenheit.
//(Formule: F = C * 9 / 5 + 32)

int Celsius;
int Fahrenheit;

Console.WriteLine ("Hoeveel graden celsius?");
Celsius = int.Parse(Console.ReadLine());

Console.WriteLine($"het aantal graden celsius is {Celsius}");

Fahrenheit = (Celsius * 9 / 5 + 32);

Console.WriteLine($"Fahrenheit: {Fahrenheit}");