string evenement, naam, namenlijst = "";
bool isGeldig; 
string invoer; 


Console.WriteLine("Evenement naam: ");
evenement = Console.ReadLine(); 

do
{ 
    Console.Write("Wilt u een naam ingeven? ");
    invoer = Console.ReadLine().ToLower(); 
    isGeldig = (invoer == "ja" ||  invoer == "nee"); 
} while (!isGeldig); 


while (invoer == "ja") 
{ 
    Console.Write("Geef naam: ");
    naam = Console.ReadLine(); 
    namenlijst += $"\n{naam}"; 
    do
    { 
        Console.Write("Wilt u een naam ingeven? ");
        invoer = Console.ReadLine().ToLower(); 
        isGeldig = (invoer == "ja" ||  invoer == "nee"); 
    } while (!isGeldig); 
}
Console.WriteLine($"Aanwezigen voor {evenement}:"); Console.WriteLine(namenlijst);