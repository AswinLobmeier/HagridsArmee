using System;

public class Personen
{
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public int Alter { get; set; }


    public Personen(string vorname, string nachname, int alter)
    {
        Vorname = vorname;
        Nachname = nachname;
        Alter = alter;
    }

    public void Eingabe() 
    {
        Console.Write("Geben Sie den Vornamen ein: ");
        Vorname = Console.ReadLine();
        Console.Write("Geben Sie den Nachnamen ein: ");
        Nachname = Console.ReadLine();
        Console.Write("Geben Sie das Alter ein: ");
        Alter = int.Parse(Console.ReadLine());
    }

    public void Anzeigen()
    {
        Console.WriteLine($"Vorname: {Vorname}, Nachname: {Nachname}, Alter: {Alter} Jahre");
    }
}
