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

    public void AnzeigenStudent(string kursTitel = "", int maxTeilnehmer = 0)
    {
        //Console.WriteLine($"| {Vorname,-12} | {Alter,-5} | {kursTitel,-36} | {maxTeilnehmer,-5} |");
        Console.WriteLine($"| {Vorname,-12} | {Alter,-5} | {kursTitel,-36} |");
    }

}
