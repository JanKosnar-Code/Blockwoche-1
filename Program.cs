using System;
using System.Diagnostics.Metrics;

public class Programm
{
    static void Main()
    {
        string? name;

        int counter = 0;

        Console.WriteLine("Gib deinen Namen ein: ");
        name = Console.ReadLine();

        int number = name.Length;

        Console.WriteLine($"Dein Name hat {number} buchstaben.");

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"Rechenschritt:{counter} + {i} = {counter + i}");
            counter += i;
        }
        Console.WriteLine(counter);
    }
}