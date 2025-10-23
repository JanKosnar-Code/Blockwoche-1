using System;
using System.Diagnostics.Metrics;

public class Programm
{
    static void Main()
    {
        int x = 0;

        bool checker = true;

        // Es Gibt 4 Verschiedene Schleifen Arten:

        // Diese schleifen laufen solange bis eine gewisse kondition nichtmehr zutrift:

        // while -> Kopfgesteuert, Die Kondition wird am Anfang geprüft
        // do-while -> Fußgesteuert, Die Kondition wird am Ende geprüft, Code wird zu Erst ausgeführt, wird mindestens 1x ausgeführt

        while (x <= 5) // gibt die zahlen 1 - 5 aus. Die Variable die in der schleife erstellt wird kann auserhalb nicht verwendet werden.
        {
            int hilfe = 3;
            Console.WriteLine(x);
            x++;
        }

        do // diese schleife führt es immer 1mal aus und prüft danach erst ab ob die bedingung erfüllt ist. Falls ja wiederholt sie das.
        {
            Console.WriteLine(x);
            checker = false;
        }
        while (checker);

        x = 0; // Resetet die Variable x auf einen festgelegten wert


        // Diese schleifen machen etwas für eine bestimmte anzahl an wiederholungen:

        // for: du kannst 3 Parameter eingeben (wert für die schleife, bedingung, was am ende der schleife passiert)
        // foreach

        for (int i = 0; x < 10; i++)
        {
            Console.WriteLine(i);
            x++;
        }

        string name = "Max";

        int length = name.Length; // Der int ist die länge des strings allso wenn der string 8 buchstaben hat hat die länge einen wert von 8

        for (int i = 0; x < length; i++) // wiederholt i 3 mal weil die länge 3 ist
        {
            Console.WriteLine(i);
        }

        foreach (char c in name) // erstellt eine Variable (c) und gibt mit dieser Variable jeden Buchstaben aus
        {
            Console.WriteLine(c);
        }

        foreach (char c in name.Reverse()) // Macht das selbe wie drüber aber gibt die buchstaben in anderer Reihenfolge ab
        {
            Console.WriteLine(c);
        }

        string? test1 = "Hallo"; // macht diesen Wert optional falls man nicht weiß ob etwas da rin sein wird (Nullable)
        int length2 = test1!.Length; // mit dem Ruffzeichen entpackt es mir die Variable gewaltsam weil ich weiß das sie garantiert einen Wert hat (Force Unwraping)
        if (test1 == null) // Sicheres Auspacken eines Optionalen wertesi (Gracefully Unwraping)
        {

        }
        // 0 ist nicht Null! 0 IST ein Wert! null ist KEIN wert

        // mit .ToLower() werden alle Großbuchstaben eines strings klein und mit .Trim() kann man Bestimmte zeichen aus strings entfernen
    }
}