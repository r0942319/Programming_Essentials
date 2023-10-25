//Schrijf een applicatie die passagiers van een bus registreert.
//De bus heeft 8 zitplaatsen en 4 daarvan zijn aan het raam.
//Vanaf dat alle plaatsen bezet zijn of wanneer de raamplaatsen bezet zijn, stop je met passagiers toevoegen.
//Vraag aan elke passagier of ze aan het raam willen zitten of niet. Enkel 'Y' of 'N' wordt aanvaardt als een geldig antwoordt.
//Wanneer alle plaatsen bezet zijn OF wanneer alle raamplaatsen bezet zijn, stop je met passagiers toevoegen.
//Toon nu het totaal aantal passagiers en hoeveel daarvan aan het raam zitten.
// een for loop van 1  tot 8 of write en read line voor elke passagier van 1 tot 8

//do
//{
// Console.Write("Waar woon je? (Geel, Olen, Herentals"); // terwijl dat de code niet g o of h is wordt deze lijn altijd herhaald daarom dat }while (!isGeldig); in de code zit
//invoer = Console.ReadLine().ToLower();                  //uppercase of lowercase g,o of h 
// isGeldig = (invoer == "g" || invoer == "o" || invoer == "h");
//} while (!isGeldig);

//bovenstaande code bijwerken voor y en n
bool isGeldig;
string invoer;
int ycounter = 0, ncounter = 0;

for (int i = 1; i <= 8; i++)
{
    do
    {
        Console.Write("Wil je aan het raam zitten? ( Y of N )");
        invoer = Console.ReadLine().ToLower();
        isGeldig = (invoer == "y" || invoer == "n");
    } while (!isGeldig);


    if (invoer == "y")
    {
        ycounter++;
        if (ycounter == 9)
            {
            break;
        }
    }
    if (invoer == "y")
    {
        ncounter++;
        if (ncounter == 9) 
        { break; }  
    }

    Console.WriteLine($"Er zijn {ycounter} passagiers.");

}

