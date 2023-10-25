//Lees voor 3 pijlen de landingsplaats en geef vervolgens een totaal van de punten weer.
//Ingevoerde waardes moeten gehele getallen zijn die groter zijn dan 0 en kleiner of gelijk aan 4.
//Na een correcte invoer, word een nieuw scherm getoond.

//Buiten de roos: 0 punten(landingsplaats 1)
//Binnenste ring: 20 punten(landingsplaats 2)
//Buitenste ring: 50 punten(landingsplaats 3)
//In het hart: 100 punten(landingsplaats 4)

string invoer;
int totaal = 0;


for (int i = 1; i <= 3; i++)
{
    int landingsplaats;
    bool isGeldig;

    do
    {
        Console.WriteLine($"Wat is uw landingsplaats {i}? 1 - 4?");
        invoer = Console.ReadLine();
        isGeldig = int.TryParse(invoer, out landingsplaats);
    } while (!isGeldig || landingsplaats < 1 || landingsplaats > 4);

    switch (landingsplaats)
    {
        case 1:
            totaal += 0;
            break;
        case 2:
            totaal += 20;
            break;
        case 3:
            totaal += 50;
            break;
        case 4:
            totaal += 100;
            break;
    }
}

Console.WriteLine($"U hebt {totaal} punten behaald");
