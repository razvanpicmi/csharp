using System;

class Program
{
    static void Main()
    {
        // Afișează un mesaj pentru utilizator
        Console.WriteLine("Introduceți un număr pentru a verifica dacă este multiplu de 5:");

        // Citește inputul utilizatorului ca text
        string input = Console.ReadLine();

        // Convertim textul într-un număr întreg
        // Folosim int.TryParse pentru a gestiona inputul incorect
        if (int.TryParse(input, out int number))
        {
            // Verificăm dacă numărul este multiplu de 5
            if (number % 5 == 0)
            {
                Console.WriteLine($"Numărul {number} este multiplu de 5.");
            }
            else
            {
                Console.WriteLine($"Numărul {number} nu este multiplu de 5.");
            }
        }
        else
        {
            // Mesaj de eroare în cazul unui input invalid
            Console.WriteLine("Inputul introdus nu este un număr valid. Vă rugăm să încercați din nou.");
        }
    }
}
