

int Kontostand = 100;

int Summe;
bool istZahl = false;


Console.WriteLine("Möchten Sie Geld einzahlen? Drücken Sie die 1");
Console.WriteLine("Möchten Sie Geld abheben? Drücken Sie die 2");
Console.WriteLine("Möchten Sie den Kontostand sehen? Drücken Sie die 3");
Console.WriteLine("Beenden, drücken sie die 0");

string Eingabe = Console.ReadLine();
istZahl = int.TryParse(Eingabe, out int Abfrage);

while (Abfrage != 0)
{

    if (Abfrage == 0)
    {
        break;
    }
    else if (Abfrage == 1)    // Einzahlen
    {
        Console.WriteLine($"Wie viel möchten Sie einzahlen");
        Summe = int.Parse(Console.ReadLine());
        Kontostand = Kontostand + Summe;
        Console.WriteLine($"Ihr neuer Kontostand beträgt {Kontostand}");
    }
    else if (Abfrage == 2) // Abheben
    {
        Console.WriteLine($"Wie viel möchten Sie abheben?");
        Summe = int.Parse(Console.ReadLine());
        Kontostand = Kontostand - Summe;
        Console.WriteLine($"Ihr neuer Kontostand beträgt {Kontostand}");

    }
    else if (Abfrage == 3) // Konstostand
    {
        Console.WriteLine($"Ihr Kontostand: {Kontostand} ");
        return;
    }
    else if (istZahl == true)
    {
        Console.WriteLine("Bite gib eine Zahl ein");
    }
}





