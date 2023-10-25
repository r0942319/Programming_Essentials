string activiteit, antwoord;
bool benJeVrij;
DateTime datumEnUur;
bool isGeldig;


do
{
    Console.Write("Welke activiteit");
    activiteit = Console.ReadLine();
    isGeldig = string.IsNullOrWhiteSpace(activiteit);   //als de activiteit niks is wordt deze bovenstaande code herhaald
} while (!isGeldig);            

do
{
    Console.Write("geef datum en uur");
    string invoer = Console.ReadLine();
    isGeldig = DateTime.TryParse(invoer, out datumEnUur)
    && datumEnUur > DateTime.Now;       //je kan hier onder deze lijn code nog meer voorwaarden toevoegen.
} while (!isGeldig);



do
{
    Console.Write("Ben je vrij? (true or false)");
    string invoer = Console.ReadLine();
    isGeldig = bool.TryParse(invoer, out benJeVrij);
} while (!isGeldig);        // terwijl de bovenstaande code niet geldig is blijven herhalen


benJeVrij = bool.Parse(Console.ReadLine());