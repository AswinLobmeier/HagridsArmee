using System;

public class Studenten
{

    public string Vorname { get; set; }
    public int Alter { get; set; }


    public Studenten(string vorname, int alter)
    {
        Vorname = vorname;
        Alter = alter;
    }
        
    public void HinzufügenStudent()
    {
        Console.Write("\nGeben Sie den Vornamen ein: ");
        Vorname = Console.ReadLine();
        Console.Write("Geben Sie das Alter ein: ");
        Alter = int.Parse(Console.ReadLine());
    }

    public void AnzeigenStudent()
    {
        Console.WriteLine($"\nVorname: {Vorname}\nAlter: {Alter} Jahre");
    }

}
