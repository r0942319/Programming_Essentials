//De telefoonmaatschappij rekent aan haar klanten jaarlijks een vast bedrag aan van € 23. Per nationale of internationale oproep
//moet je nog eens € 0,12 bijbetalen.
//In deze tarieven is geen btw inbegrepen.
//Schrijf een programma dat het aantal jaarlijkse nationale en internationale oproepen
//opvraagt en de totaalprijs afdrukt inclusief btw. We veronderstellen een btw-percentage van 21%.

int Natoproep;
int IntNatoproep;
double totaalprijs;
double totaalprijsbtw;
double btw = 21;
double totalekostennat;
double totalekostenintnat;



Console.WriteLine("Hoeveel nationale oproepen?");
Natoproep = int.Parse (Console.ReadLine());

Console.WriteLine("Hoeveel internationale oproepen?");
IntNatoproep = int.Parse(Console.ReadLine());

totalekostennat = Natoproep * 0.12;
totalekostenintnat = IntNatoproep * 0.12;
totaalprijs =  23 + (totalekostennat + totalekostenintnat);

totaalprijsbtw = totaalprijs + (totaalprijs * (btw / 100));

Console.WriteLine($"Totaal te betalen: {totaalprijsbtw} ");




