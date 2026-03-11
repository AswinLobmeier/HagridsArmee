using System;

public class Methode4_5
{
    public static void MaxZahl(int a, int b)
    {
        var numbers = new List<int> { a, b };
        int maxZahl = numbers.Max();  //https://www.csharp-examples.net/linq-max/   
        Console.WriteLine($"\nDie größere Zahl von {a} und {b} ist {maxZahl}");
    }
}