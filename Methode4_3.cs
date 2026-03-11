using System;

public class Methode4_3
{
    public static void IstGerade(int a, int b)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine($"\nAusserdem kann ich Dir noch sagen, {a} ist eine gerade Zahl...");
        }
        else
        {
            Console.WriteLine($"\nAusserdem kann ich Dir noch sagen, {a} ist keine gerade Zahl...");       
        }

        if (b % 2 == 0)
        {
            Console.WriteLine($"\n...und die Zahl {b} ist gerade.");
        }
        else
        {
            Console.WriteLine($"\n...und die Zahl {b} ist keine gerade Zahl.");
        }
    }
}