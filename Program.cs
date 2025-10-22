using System;

public class Programm
{
    static void Main()
    {
        int zahl1;
        int zahl2;
        int Ergebnis1;
        int Ergebnis2;

        char Rechenoperator;

        Console.WriteLine("Erste Zahl: ");
        zahl1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zweite Zahl: ");
        zahl2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Rechenoperator: ");
        Rechenoperator = Convert.ToChar(Console.ReadLine());

        switch(Rechenoperator)
        {
            case '+': Ergebnis1 = zahl1 + zahl2; Console.WriteLine(Ergebnis1); break;
            case '-': Ergebnis1 = zahl1 - zahl2; Console.WriteLine(Ergebnis1); break;
            case '*': Ergebnis1 = zahl1 * zahl2; Console.WriteLine(Ergebnis1); break;
            case ':': Ergebnis1 = zahl1 / zahl2; Ergebnis2 = zahl1 % zahl2; Console.WriteLine(Ergebnis1 + " " + Ergebnis2); break;
        }
    }
}