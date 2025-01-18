using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Primele 10 numere pare sunt:");

        // Inițializare variabilă pentru a stoca numerele pare
        int count = 0;

        // Inițializare buclă
        for (int i = 0; count < 10; i += 2)
        {
            Console.WriteLine(i); // Afișează numărul par
            count++;             // Crește numărul de numere afișate
        }
    }
}
