//Schrijf een programma dat voor een bepaald coördinaat bepaalt in welk kwadrant dit ligt. 0 wordt hier aanzien als een positief getal.
//X: 0 en Y: 5 zal dus in het eerste kwadrant liggen. X: 5 en Y: 0 zal dus ook in het eerste kwadrant liggen.

//De gebruiker geeft een X en Y coördinaat op.

//zie website: https://www.splashlearn.com/math-vocabulary/geometry/quadrant

using System.Collections.Generic;

string uitkomst = "";


Console.WriteLine("Wat is X?");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Wat is Y?");
int y = int.Parse(Console.ReadLine());



{
    if (x == 0 && y == 0)
    {
        Console.WriteLine("Punt ligt in de oorsprong.");
    }
    if ((x > 0 && y > 0) || (x == 0 && y != 0))
    {
        Console.WriteLine("Punt ligt in het eerste kwadrant.");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("Punt ligt in het tweede kwadrant.");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("Punt ligt in het derde kwadrant.");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("Punt ligt in het vierde kwadrant.");
    }

}