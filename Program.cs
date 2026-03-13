using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Numerics;

public class Program
{
    public static void Main()
    {

        /*  
        //########################################################################################## Aufgabe 1 ########################################################################################## 
        // 1.1
        Personen personen = new Personen("", "", 0);
        personen.Eingabe();
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();
        personen.Anzeigen();
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        //1.2
        Console.Write("\nHallo, mein Name ist Aswin, Wie heißt Du: ");
        string Fremder = Console.ReadLine();
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 1.3
        Console.Write($"\nHallo {Fremder}, schön dich kennenzulernen! Wie Alt bist Du den: ");
        int alterFremder = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ach {Fremder}, du bist schon {alterFremder} Jahre alt!");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 1.4
        int a = 10;
        int b = 20;

        int summe = a + b;
        int differenz = b - a;
        int produkt = a * b;

        Console.WriteLine($"\nHallo {Fremder}, ich rechne mit 10 und 20, die Summe = {summe}, die Differenz = {differenz} und das Produkt = {produkt}");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 1.5
        Console.Write($"\nHallo {Fremder}, sag mir eine beliebige Zahl: ");
        a = int.Parse(Console.ReadLine());
        Console.Write($"\nHallo {Fremder}, sag mir noch eine zweite beliebige Zahl: ");
        b = int.Parse(Console.ReadLine());
        summe  = a * b;
        Console.WriteLine($"{Fremder}, die Summe von {a} und {b} ist {summe}");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 1.6
        Console.Write($"\nHallo {Fremder}, sag mir eine beliebige Zahl: ");
        a = int.Parse(Console.ReadLine());
        int quadrat = a * a;
        Console.WriteLine($"{Fremder}, das Quadrat von {a} ist {quadrat}");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        //########################################################################################## Aufgabe 2 ########################################################################################## 


        // 2.1
        do
        {
            Console.Write($"\nHallo {Fremder}, sag mir eine Zahl zwischen 0 und 20: ");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case <= 20 and > 10:
                    Console.WriteLine($"\n{Fremder}, die Zahl {a} ist GROSS");
                    break;
                case <= 10 and >= 0:
                    Console.WriteLine($"\n{Fremder}, die Zahl {a} ist klein");
                    break;
                default:
                    Console.WriteLine($"\n{Fremder}, ich habe doch gesagt, sag mir eine Zahl zwischen 0 und 20!");
                    break;
            }
        } 
        while (a > 20 || a < 0);
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 2.2
        do
        {
            Console.Write($"\nHallo {Fremder}, wie denkst Du ist die AP1 gelaufen?\n" +
                $"wieviele Punkte hast Du wohl bekommen? Zahl zwischen 0 und 100: ");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case <= 100 and >=50:
                    Console.WriteLine($"\n{Fremder}, mit {a} Punkten hast Du bestanden..");
                    break;
                case < 50 and >= 0:
                    Console.WriteLine($"\n{Fremder}, mit {a} Punkten hast Du leider nicht bestanden");
                    break;
                default:
                    Console.WriteLine($"\n{Fremder}, ich habe doch gesagt, sag mir eine Zahl zwischen 0 und 100!");
                    break;
            }
        }
        while (a > 100 || a < 0);
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 2.3
        switch (a)
        {
            case >= 90:
                Console.WriteLine($"\n{Fremder}, mit {a} Punkten hast Du die Note 1..");
                break;
            case >= 80:
                Console.WriteLine($"\n{Fremder}, mit {a} Punkten hast Du die Note 2..");
                break;
            case >= 70:
                Console.WriteLine($"\n{Fremder}, mit {a} Punkten hast Du die Note 3..");
                break;
            case >= 60:
                Console.WriteLine($"\n{Fremder}, mit {a} Punkten hast Du die Note 4..");
                break;
            default:
                Console.WriteLine($"\n{Fremder}, so wirklich gelernt hast Du ja nicht.. Oder..??");
                break;
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 2.4
        if (alterFremder >= 18)
            {
                Console.WriteLine($"\nHallo {Fremder},\n" +
                    $"eigentlich hätte ich Dich nach dem Alter Fragen sollen,\n" +
                    $"aber das hast Du mir vorher eh schon gegeben,\n" +
                    $"und mit {alterFremder} Jahren bist Du sowiso volljährig!");
            }
        else if (alterFremder < 18)
            {
                Console.WriteLine($"\nHallo {Fremder},\n" +
                    $"eigentlich hätte ich Dich nach dem Alter Fragen sollen,\n" +
                    $"aber das hast Du mir vorher eh schon gegeben,\n" +
                    $"und ich habe festgestellt das Du mit {alterFremder} Jahren leider Minderjährig bist!");
            }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        // 2.5
        Console.Write($"\nHallo {Fremder}, sag mir eine beliebige Zahl: ");
        a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
            {
            Console.WriteLine($"\nHy {Fremder}, {a} ist eine gerade Zahl..");
            }
        else if (a % 2 != 0)
        {
            Console.WriteLine($"\nHy {Fremder}, {a} ist eine ungerade Zahl..");
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");  
        Console.ReadKey();
        Console.Clear();

        // 2.6
        Console.Write($"\nHallo {Fremder}, gib mir eine beliebige Zahl: ");
        a = int.Parse(Console.ReadLine()); 
        Console.Write($"\nHallo {Fremder}, gib mir noch eine zweite Zahl: ");
        b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"\n{Fremder}, ist Dir aufgefallen das {a} größer ist als {b}..?");
        }
        else if (b > a)
        {
            Console.WriteLine($"\n{Fremder}, ist Dir aufgefallen das {b} größer ist als {a}..?");
        }
        else if (a == b)
        {
            Console.WriteLine($"\n{Fremder}, ist Dir aufgefallen das {a} und {b} gleich groß sind..?");
        }
         Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");  
         Console.ReadKey();
         Console.Clear();

        //########################################################################################## Aufgabe 3 ##########################################################################################        

        Console.WriteLine("Aufgabe 3.1: Gib Zahlen von 1-20 aus..\n");
        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Aufgabe 3.2: Gib nur gerade Zahlen von 1-50 aus..\n");
        for (int i = 1; i <= 50; i++)
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        Console.WriteLine("");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Aufgabe 3.3: Berechne Summe von 1 -100..\n");
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
            Console.WriteLine($"{sum}");
        }
        Console.WriteLine("");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Aufgabe 3.4: Frage nach Zahl und gib Zahlen bis zu der Zahl aus\n");
        Console.Write("Gib mir bitte eine Zahl zwischen 1 und 50: ");
        int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 50)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
                Console.WriteLine("Bitte eine Zahl zwischen 1 und 50..");
        Console.WriteLine("");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Aufgabe 3.5: Erstelle eine Multiplikationstabelle\n");
        int a = 20;
        Console.WriteLine("________________");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"|{a} x {i} = {a * i}\t|");
        }

        Console.WriteLine("________________");
        Console.WriteLine("");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Aufgabe 3.6: zähle rückwärts..\n");
        for (int i = 20; i > 0; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        //########################################################################################## Aufgabe ´4 ########################################################################################## 

        Methode4_1.SagHallo(personen.Vorname, personen.Nachname, personen.Alter);
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        int a = 1;
        int b = 2;

        Console.Write($"\nHallo, sag mir eine beliebige Zahl: ");
        a = int.Parse(Console.ReadLine());
        Console.Write($"\n...sag mir noch eine zweite beliebige Zahl: ");
        b = int.Parse(Console.ReadLine());


        Methode4_2.Addieren(a, b);
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Methode4_3.IstGerade(a, b);
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Methode4_4.Quadrat(a, b);
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Methode4_5.MaxZahl(a, b);
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Methode4_6.NoteBerechnen();
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        //########################################################################################## Aufgabe 5 ########################################################################################## 

        Console.Write($"\nHallo, sag mir eine Automarke: ");
        string auto1 = Console.ReadLine();
        Console.WriteLine($"\nWelches Baujahr ist dein {auto1}?: ");
        int baujahr1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nWie schnell wird dein {auto1} fahren?: ");
        int geschwindigkeit1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        Console.Write($"\nHallo, sag mir eine weitere Automarke: ");
        string auto2 = Console.ReadLine();
        Console.WriteLine($"\nWelches Baujahr ist dein {auto2}?: ");
        int baujahr2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nWie schnell wird dein {auto2} fahren?: ");
        int geschwindigkeit2 = int.Parse(Console.ReadLine());
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Auto auto_1 = new Auto(auto1, baujahr1);      //5.2
        auto_1.Anzeigen();                                    //5.2
        auto_1.Fahren(geschwindigkeit1);                                //5.5
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        Auto auto_2 = new Auto(auto2, baujahr2);      //5.3
        auto_2.Anzeigen();                                    //5.3
        auto_2.Fahren(geschwindigkeit2);                                   //5.5
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();



        Console.WriteLine("Liste mit 5 Autos erstellen..\n");
        Auto[] autos = new Auto[5];
        //autos.Clear();
        for (int i = 0; i < autos.Length; i++)

        {
            int j = i + 1;
            Console.Write($"\nHallo, sag mir eine {j}te von {autos.Length} Automarken: ");
            string autoNew = Console.ReadLine();
            Console.WriteLine($"\nWelches Baujahr ist dein {autoNew}?: ");
            int baujahrNew = int.Parse(Console.ReadLine());
            Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
            Console.ReadKey();
            Console.Clear();

            autos[i] = new Auto(autoNew, baujahrNew);
        }

        Console.WriteLine("\nIn der Liste sind alle deine Autos..\n");
         foreach (Auto auto in autos)
         {
             auto.Anzeigen();
         }
         Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
         Console.ReadKey();
         Console.Clear();


        //########################################################################################## Aufgabe 6 ########################################################################################## 

        Auto auto1 = new Auto("Ford", 2013);
        Auto auto2 = new Auto("BMW", 2024);
        Auto auto3 = new Auto("Mercedes", 2025);

        Console.WriteLine($"\n Automarke 1: {auto1.Marke}\t Baujahr: {auto1.Baujahr}");
        Console.WriteLine($" Automarke 2: {auto2.Marke}\t Baujahr: {auto2.Baujahr}");
        Console.WriteLine($" Automarke 3: {auto3.Marke}\t Baujahr: {auto3.Baujahr}");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        */

        //########################################################################################## Aufgabe 7 ########################################################################################## 
        /*
        List<Studenten> listeStudenten = new List<Studenten>();

        Console.WriteLine($"\nHallo, aktuell befinden sich {listeStudenten.Count()} Studenten in der Liste");
        Console.WriteLine("\nWieviele neue Studenten sollen hinzugefügt werden?: ");
        int anzahlStudenten = int.Parse(Console.ReadLine());
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        for (int i = 0; i < anzahlStudenten; i++)
        {
            Console.WriteLine($"\nEingabe Student {i + 1} von gewünschtrn {anzahlStudenten} Studenten...");
            Studenten student = new Studenten("", 0);
            student.HinzufügenStudent();
            listeStudenten.Add(student);
            Console.Clear();
        }

        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        foreach (Studenten s in listeStudenten)
        {
            s.AnzeigenStudent();
        }

        Console.WriteLine($"\nHallo, jetzt befinden sich {listeStudenten.Count()} Studenten in der Liste");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();
        */

        //########################################################################################## Aufgabe 8 ##########################################################################################
        /*
        Console.WriteLine("\nAusgabe aller Studenten über 20 Jahre [8.1]");
        var studentUeber20 = listeStudenten.Where(s => s.Alter > 20);
        foreach (var student in studentUeber20)
        {
            student.AnzeigenStudent();
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nAusgabe aller Studenten unter 18 Jahre [8.2]");
        var studentU18 = listeStudenten.Where(s => s.Alter < 18);
        foreach (var student in studentU18)
        {
            student.AnzeigenStudent();
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nZählen aller Studenten über 25 Jahre [8.3]");
        var studentUeber25 = listeStudenten.Where(s => s.Alter > 25);
        Console.WriteLine($"\nHallo, es befinden sich {studentUeber25.Count()} Studenten über 25 Jahre in der Liste");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nSortieren aller Studenten nach Alter [8.4]");
        var sortiereStudenten = listeStudenten.OrderBy(s => s.Alter);
        foreach (var student in sortiereStudenten)
        {
            student.AnzeigenStudent();
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nNur den Namen Ausgeben [8.5]");
        var nurNamen = listeStudenten.Select(s => s.Vorname);
        foreach (var vorname in nurNamen)
        {
            Console.WriteLine($"\n{vorname}");
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nDen ältesten Studenten anzeigen [8.6]");
        var aeltester = listeStudenten.Max(s => s.Alter);       // erst max und dann verweisen
        var aeltesterStudent = listeStudenten.Where(s => s.Alter == aeltester);
        foreach (var student in aeltesterStudent)
        {
            student.AnzeigenStudent();
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();
       */
        //########################################################################################## Aufgabe 9 ##########################################################################################

        // https://learntutorials.net/de/csharp/topic/68/linq-abfragen
        /*
        Console.WriteLine("\nDas Durchschnittsalter der Studenten mit Hilfe LINQ anzeigen[9.1]");
        Console.WriteLine("-----------------------------------------------------------------");
        var alterDurchschnitt = listeStudenten.Average(s => s.Alter);
        Console.WriteLine($"\nDas Durchschnittsalter der Studenten beträgt: {alterDurchschnitt}");
        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nDen ältesten Studenten mit Hilfe LINQ anzeigen [9.2]");
        Console.WriteLine("----------------------------------------------------");
        var aeltester2 = listeStudenten.Max(s => s.Alter);
        var aeltesterStudent2 = listeStudenten.Where(s => s.Alter == aeltester2);
        foreach (var student in aeltesterStudent2)
        {
            student.AnzeigenStudent();
        }
        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("\nSortieren aller Studenten nach Alter mit Hilfe LINQ [9.3]");
        Console.WriteLine("---------------------------------------------------------");
        var sortiereStudenten2 = listeStudenten.OrderBy(s => s.Alter);
        foreach (var student in sortiereStudenten2)
        {
            student.AnzeigenStudent();
        }
        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("\nFiltern aller Studenten über 20 Jahre mit Hilfe LINQ [9.4]");
        Console.WriteLine("----------------------------------------------------------");
        var studentUeber20 = listeStudenten.Where(s => s.Alter > 20);
        foreach (var student in studentUeber20)
        {
            student.AnzeigenStudent();
        }
        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("\nZählen aller Studenten über Hilfe LINQ [9.5]");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"\nHallo, es befinden sich {listeStudenten.Count()} Studenten in der Liste");
        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nNur den Vornamen der Studenten Ausgeben LINQ [9.6]");
        Console.WriteLine("--------------------------------------------------");
        var nurVornamen = listeStudenten.Select(s => s.Vorname);
        foreach (var vorname in nurVornamen)
        {
            Console.WriteLine($"\n{vorname}");
        }
        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();
        */
        //########################################################################################## Aufgabe 10 ##########################################################################################

        //https://learntutorials.net/de/csharp/topic/40/ausnahmebehandlung
        /*
        Console.WriteLine("\nAufgabe [10.3], Frage nach Zahl und Aufgabe [10.2], fange Division durch 0 ab");
        Console.WriteLine("-----------------------------------------------------------------------------");

        Console.WriteLine("\nIch möchte 3 Divisionen berechnen!");

        Console.WriteLine("\nGib für Berechnung 1 die [erste] Zahl ein: ");
        int a = int.Parse(Console.ReadLine());

        int b = 0;
        do
        {
            Console.WriteLine("\nGib für Berechnung 1 die [zweite] Zahl ein (Test Abfangen 0): ");
            b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine($"\nBitte keine 0 eingeben, versuch es nochmal!");
            }
        }   
        while (b == 0);

        Console.Clear();
        Console.WriteLine("\nGib für Berechnung 2 die [erste] Zahl ein: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGib für Berechnung 2 die [zweite] Zahl ein: ");
        int d = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("\nGib für Berechnung 3 die [erste] Zahl ein: ");
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGib für Berechnung 4 die [zweite] Zahl ein: ");
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("\nAufgabe [10.1], erstelle Division und Aufgabe [10.4], fange Division durch 0 mit TryParse ab,\n" +
            "Aufgabe [10.5], eigene Exception, Aufgabe[10.6], Fehlermeldung anzeigen");
        Console.WriteLine("--------------------------------------------------------------------------------------------");


        Console.WriteLine($"\nDivision {a} / {b}\t = {a / b:F2}");

        try
        {
            try
            {
                double division2 = c / d;
            }
            catch (DivideByZeroException dzEx) when (d == 0)
            {
                Console.WriteLine($"\nAchtung: Division durch 0 ist nicht möglich! ({dzEx.Message}");
            }
            finally
            {
                if (d != 0)
                {
                    Console.WriteLine($"\nDivision {c} / {d}\t = {(double)c / d:F2}");
                }
                else
                {
                    Console.WriteLine($"Division {c} / {d}\t = [Fehler]");
                }
            }

            try
            {
                double division3 = e / f;
            }
            catch (DivideByZeroException dzEx) when (f == 0)
            {
                Console.WriteLine($"\nAchtung: Division durch 0 ist nicht möglich! ({dzEx.Message}");
            }
            finally
            {
                if (f != 0)
                {
                    Console.WriteLine($"\nDivision {e} / {f}\t = {(double)e / f:F2}");
                }
                else
                {
                    Console.WriteLine($"Division {e} / {f}\t = [Fehler]");
                }
            }  
        }            
        catch (Exception Ex)
        {
            Console.WriteLine($"\nEs ist ein unerwarteter Fehler aufgetreten! ({Ex.Message})");
        }

        Console.WriteLine("\n\n\n\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        */

        //########################################################################################## Aufgabe 11 ##########################################################################################


        Kurs informatik = new Kurs("Informatik", 20);
        Kurs wiso = new Kurs("Wirtschafts- und Sozialkunde", 5);
        Kurs elektro = new Kurs("Elektrotechnik", 3);
        
        Studenten s1 = new Studenten("Aswin", 47);
        Studenten s2 = new Studenten("Agnes", 38);
        Studenten s3 = new Studenten("Marco", 44);
        Studenten s4 = new Studenten("Tobi", 22);
        Studenten s5 = new Studenten("Ramona", 28);

        informatik.StudentHinzufügen(s1);
        informatik.StudentHinzufügen(s2);
        informatik.StudentHinzufügen(s3);
        informatik.StudentHinzufügen(s4);
        informatik.StudentHinzufügen(s5);
        informatik.StudentenAnzeigen();
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        wiso.StudentHinzufügen(s1);
        wiso.StudentHinzufügen(s2);
        wiso.StudentHinzufügen(s3);
        wiso.StudentHinzufügen(s4);
        wiso.StudentHinzufügen(s5);
        wiso.StudentenAnzeigen();
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        elektro.StudentHinzufügen(s1);
        elektro.StudentHinzufügen(s2);
        elektro.StudentHinzufügen(s3);
        elektro.StudentHinzufügen(s4);
        elektro.StudentHinzufügen(s5);
        elektro.StudentenAnzeigen();
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        //########################################################################################## Aufgabe 12 ##########################################################################################

        List<Kurs> alleKurse = new List<Kurs> { informatik, wiso, elektro };

        // Anzahl Kurse – flexibel!
        int kurseGesamt = alleKurse.Count;
        int studentenGesamt = alleKurse.Sum(k => k.AnzahlStudenten());
        var alleStudenten = alleKurse.SelectMany(k => k.KursTeilnehmer);
        double durchschnitt = alleStudenten.Average(s => s.Alter);

        Console.WriteLine($"\nAktuell befinden sich {studentenGesamt} Studenten in {kurseGesamt} Kursen, dabei ist das Durchschnittsalter {durchschnitt:F2} Jahre");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();
     
        Studenten aeltesterStudent = alleStudenten.MaxBy(s => s.Alter);
        Console.WriteLine($"\nÄltester Student ist {aeltesterStudent.Vorname} mit {aeltesterStudent.Alter} Jahren");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        Studenten juengster = alleStudenten.MinBy(s => s.Alter);
        Console.WriteLine($"Jüngster Student ist {juengster.Vorname} mit {juengster.Alter} Jahren");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        var sortiertNachAlter = alleStudenten.OrderBy(s => s.Alter).Distinct();
        Console.WriteLine("\nSortierte Liste nach Alter");
        foreach (var s in sortiertNachAlter)
        {
            Console.WriteLine($"  {s.Vorname,-12} | {s.Alter} Jahre");
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();

        var nurNamen = alleStudenten.Select(s => s.Vorname).Distinct();
        Console.WriteLine("\nAlle Studenten");
        foreach (var name in nurNamen)
        {
            Console.WriteLine($"  {name}");
        }
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();


    }
}

