using System;
using System.Diagnostics.Metrics;

public class Programm
{
    static void Main()
    {
        string? wort;
        string zwischen1 = "";
        string zwischen2 = "";

        Console.WriteLine("Gib ein Wort ein: ");
        wort = Console.ReadLine();

        foreach (char c in wort!.ToLower())
        {
            zwischen1 += c;
        }

        foreach (char c in wort.ToLower().Reverse())
        {
            zwischen2 += c;
        }

        Console.WriteLine(zwischen1 + " " + zwischen2);

        if (zwischen1 == zwischen2)
        {
            Console.WriteLine("Es Ist Richtig");
        }
        else
        {
            Console.WriteLine("Es Ist Falsch");
        }
    }
}