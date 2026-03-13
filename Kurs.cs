using System;

public class Kurs
{
	public string Titel { get; set; }
	public int MaxTeilnehmer { get; set; } = 10;
	public List<Studenten> KursTeilnehmer { get; set; } = new List<Studenten>();  
	
	public Kurs(string titel, int maxteilnehmer)
	{
		Titel = titel;
		MaxTeilnehmer = maxteilnehmer;
	}

	public void StudentHinzufügen(Studenten student)
	{
        if (KursTeilnehmer.Count >= MaxTeilnehmer)
        {
            Console.WriteLine($"\n\nDer Kurs {Titel} ist voll,\nes sind maximal {MaxTeilnehmer} Teilnehmer erlaubt,\n{student.Vorname} kann leider nicht mehr teilnehmen");
            return;            
        }

        KursTeilnehmer.Add(student);
    }
    
    public void StudentenAnzeigen()
    {
        //Console.WriteLine($"DEBUG: MaxTeilnehmer = {MaxTeilnehmer}");
        
        //Console.WriteLine($"\n {new string('_', 69)}");
        //Console.WriteLine($"|{new string(' ', 16)}  {Titel,-33}  {new string(' ', 16)}|");
        Console.WriteLine($"\n\n Kurs: {Titel} ({KursTeilnehmer.Count} Teilnehmer / {MaxTeilnehmer} erlaubt)");
        Console.WriteLine($"|{new string('_', 61)}|");
        //Console.WriteLine($"|{new string(' ', 14)}|{new string(' ', 7)}|{new string(' ', 38)}|{new string(' ', 7)}|");
        Console.WriteLine($"|{new string(' ', 14)}|{new string(' ', 7)}|{new string(' ', 38)}|");
        //Console.WriteLine($"| {"Vorname",-12} | {"Alter",5} | {"Kurs",-36} | {"[max]",-5} |");
        Console.WriteLine($"| {"Vorname",-12} | {"Alter",5} | {"Kurs",-36} |");
        // Console.WriteLine($"|{new string('-', 14)}|{new string('-', 7)}|{new string('-', 38)}|{new string('-', 7)}|");
        Console.WriteLine($"|{new string('-', 14)}|{new string('-', 7)}|{new string('-', 38)}|");
        foreach (var s in KursTeilnehmer)
		{
			s.AnzeigenStudent(Titel, MaxTeilnehmer);
            //Console.WriteLine($"|{new string(' ', 14)}|{new string(' ', 7)}|{new string(' ', 38)}|{new string(' ', 7)}|");
            Console.WriteLine($"|{new string(' ', 14)}|{new string(' ', 7)}|{new string(' ', 38)}|");
        }
	}

    public int AnzahlStudenten()
    {
        return KursTeilnehmer.Count();
    }
}
