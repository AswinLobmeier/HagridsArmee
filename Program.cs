using System;
using System.ComponentModel.Design;

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

        List<Studenten> listeStudenten = new List<Studenten>();

        Console.WriteLine($"\nHallo, aktuell befinden sich {listeStudenten.Count} Studenten in der Liste");
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

        Console.WriteLine($"\nHallo, jetzt befinden sich {listeStudenten.Count} Studenten in der Liste");
        Console.WriteLine("\n..beliebige Taste zum fortfahren drücken..");
        Console.ReadKey();
        Console.Clear();







    }
}

