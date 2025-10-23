using System;
using System.Diagnostics.Metrics;

public class Programm
{
    static void Main()
    {
        int i = 1;

        int rzahl;
        int zahl;
        int zwischen;

        bool checker = true;

        Console.WriteLine("Gib eine zahl ein: ");
        zahl = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Gib eine die zahl ein durch die geteilt wird: ");
        rzahl = Convert.ToInt32(Console.ReadLine());

        while (checker)
        {
            zwischen = i % rzahl;

            if (zwischen > 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine($"Die zahl {i} ist durch {rzahl} teilbar!");
            }

            if (i == zahl)
            {
                checker = false;
            }

            i++;
        }
    }
}