int uitkomst;



Console.WriteLine("Wat is uw landingsplaats? 1 - 4?");
uitkomst = int.Parse(Console.ReadLine());

string letter = "";

switch (uitkomst)
{

    case 1:
        letter = "0 punten.";
        break;
    case 2:
        letter = "20 punten.";
        break;
    case 3:
        letter = "50 punten.";
        break;
    case 4:
        letter = "100 punten.";
        break;

}
Console.WriteLine($"{letter}");


