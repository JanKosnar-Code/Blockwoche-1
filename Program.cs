using System;

public class Programm
{
    static void Main()
    {
        int Zahl;

        Console.WriteLine("Gib eine Zahl ein: ");
        Zahl = Convert.ToInt32(Console.ReadLine());

        if(Zahl % 2 > 0)
        {
            Console.WriteLine("Ist nicht durch 2 Teilbar");
        }
        else
        {
            Console.WriteLine("Ist durch 2 Teilbar");
        }
    }
}