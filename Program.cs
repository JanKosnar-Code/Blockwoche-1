using System;

public class Programm
{
    static void Main()
    {
        int age = 10;

        switch(age) // switch ist das selbe wie ff/else aber es ist praktischer alls if/else bei repetetiven sachen
        {
            case int n when (n > 0 && n < 10): Console.WriteLine(); break;
            case int n when (n > 10 && n < 20): Console.WriteLine(); break;
            case int n when (n > 20 && n < 30): Console.WriteLine(); break;
            case int n when (n > 30 && n < 40): Console.WriteLine(); break;
            default: Console.WriteLine(); break;
        }
    }
}