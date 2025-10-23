using System;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

public class Programm
{
    static void Main()
    {
        while (true) // Endlosschleife. break; unterbricht die schleife in der zeile in der es steht
        {
            int i = 0; // wird ausgeführt

            break;
            i++;       // wird nichtmehr ausgeführt
        }

        for (; ; ) // Endlosschleife in einer for schleife
        {
            break;
        }

        for (int i = 0; i < 100; i += 2) // Continue Restartet die schleife an dem punkt wo Continue steht
        {
            if (i < 50)
            {
                continue;
            }

            Console.WriteLine(i);
        }

        while (true) // Eine sehr Verschachtelte schleife... ist auch möglich
        {
            for (int i = 0; i < 10; i++)
            {
                string x = "Hal\nlo";
                foreach (char y in x)
                {
                    do
                    {
                        Console.WriteLine(y);
                    }
                    while (y != '\n');
                }
            }
        }

        // Das ist goto. mit goto kann man zu bestimten orten im code springen. Jedoch ist goto nicht gut zum lesen, fehleranfällig und die Lesbarkeit ist schlecht allso nicht verwenden.

        int c = 0;
    Label:
        c++;
        if (c > 5)
        {
            goto End;
        }
        int k = 0;
        int j = 0;
        Console.WriteLine(k);
        k++;
        j++;
        Console.WriteLine(j);
        goto Label;
    End:
        Console.WriteLine("Ciao");
    }
}