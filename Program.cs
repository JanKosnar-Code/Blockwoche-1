using System;

public class Programm
{
    static void Main()
    {
        int age;
        Console.WriteLine("Wie alt bist du?: ");
        age = Console.ReadLine(); // Hier ist ein Fehler weil Readline standardmäsig ein String ist
        Console.WriteLine(age);

        int age2;
        Console.WriteLine("Wie alt bist du?: ");
        age2 = Convert.ToInt32(Console.ReadLine()); // Hier wird Console Writeline zu Int umgewandelt mit 32 Bit
        Console.WriteLine(age2);

        // das rechnen funktioniert mit allen rechenarten

        age = age + 5; // rechnet dem alter 5 dazu
        age += 5; // das selbe aber kürzer
    }
}