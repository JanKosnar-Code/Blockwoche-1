using System;

public class Programm
{
    static void Main()
    {
        // Variablen

        int zahl1;
        int zahl2;
        int Ergebnis;

        // Eingabe

        Console.WriteLine("Erste Zahl");
        zahl1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zweite Zahl");
        zahl2 = Convert.ToInt32(Console.ReadLine());

        Ergebnis = zahl1 + zahl2; // Rechnet

        Console.WriteLine(Ergebnis); // Ausgabe
    }
}