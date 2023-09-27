int getal;
int deler1;
int deler2;
deler1 = 5;
deler2 = 11;

Console.WriteLine("Geef een getal");
getal = int.Parse (Console.ReadLine());

Console.WriteLine($"Uw getal is {getal}");

bool resultaat = getal % deler1 == 0; 
Console.WriteLine("Deelbaar");
bool resultaat2 = getal % deler2 == 0;
Console.WriteLine ("Deelbaar");
bool resultaat3 = getal % deler1 == 1;
Console.WriteLine("Niet deelbaar");
bool resultaat4 = getal % deler2 == 1;
Console.WriteLine("Niet deelbaar");


// de bovenstaande code checkt of dat de input getal deelbaar is door deler 1 en deler 2 zonder overschot want % doet een deling met overschot
// als er overschot is dan kan je natuurlijk niet delen maar als je antwoord exact 0 is dan wel 
