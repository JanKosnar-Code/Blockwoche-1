using System;

public class Programm
{
    static void Main()
    {
        // Variablen

        string? name;
        int age;

        // Abfragen

        Console.WriteLine("Was ist dein name?: ");
        name = Console.ReadLine();

        Console.WriteLine("Wie alt bist du?: ");
        age = Convert.ToInt32(Console.ReadLine());

        age += 30; // +30 Zu Alter

        Console.WriteLine($"Hallo {name}. in 30 Jahren bist du {age}."); // Ausgabe
    }
}