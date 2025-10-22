using System;

public class Programm
{
    static void Main()
    {
        int zahl;
        string a = "";
        string b = "";

        Console.WriteLine("Gib eine Zahl ein: ");
        zahl = Convert.ToInt32(Console.ReadLine());

        if (zahl % 3 == 0)
        {
            a = "FIZZ";
        }

        if (zahl % 5 == 0)
        {
            b = "BUZZ";
        }
        Console.WriteLine(a + b);

        if (a != "FIZZ" && b != "BUZZ")
        {
            Console.WriteLine(zahl);
        }
    }
}