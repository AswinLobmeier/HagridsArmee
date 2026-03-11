using System;

public class Methode4_6
{
    public static void NoteBerechnen()
    {
        
        int a;

        do
        {
            Console.Write($"\nHallo, wie denkst Du ist die AP1 gelaufen?\n" +
                $"wieviele Punkte hast Du wohl bekommen? Bitte Zahl zwischen 0 und 100 eingeben: ");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case <= 100 and >= 90:
                    Console.WriteLine($"\n... mit {a} Punkten hast Du die Note 1..");
                    break;
                case < 90 and >= 80:
                    Console.WriteLine($"\n... mit {a} Punkten hast Du die Note 2..");
                    break;
                case < 80 and >= 70:
                    Console.WriteLine($"\n... mit {a} Punkten hast Du die Note 3..");
                    break;
                case < 70 and >= 60:
                    Console.WriteLine($"\n... mit {a} Punkten hast Du die Note 4..");
                    break;
                case < 60 and >= 0:
                    Console.WriteLine($"\n... so wirklich gelernt hast Du ja nicht.. Oder..??");
                    break;
                default:
                    Console.WriteLine($"\n... ich habe doch gesagt, sag mir eine Zahl zwischen 0 und 100!");
                    break;
            }
        }
        while (a > 100 || a < 0);
    }
}