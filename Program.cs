using System;

public class Programm
{
    static void Main()
    {
        string text; // Deklariert eine Variable
        text = string.Empty; // oder "" initialiseren eine Variable
        Console.WriteLine("Hallo Welt!");
        text = Console.ReadLine(); // speichert die eingabe in text
        Console.WriteLine(text);
    }
}