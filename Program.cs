using System;

public class Programm
{
    static void Main()
    {
        int age;

        bool a;

        Console.WriteLine("Wie alt bist du?: ");
        age = Convert.ToInt32(Console.ReadLine());

        a = age >= 18;

        if (a)
        {
            Console.WriteLine("Du darfst rein.");
        }
        else
        {
            Console.WriteLine("Du bist zu Jung");
        }
    }
}