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

    }
}

