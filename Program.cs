using System;

public class Program
{
    public static void Main()
    {    
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
    }
}

