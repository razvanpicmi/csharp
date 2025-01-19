bool IsPrime(int number)
{
    // Cazuri speciale:
    // 1 nu este considerat număr prim,
    // numerele negative sau 0 nici ele nu sunt prime.
    if (number <= 1)
    {
        return false;
    }

    // Verificăm divizori până la rădăcina pătrată a numărului
    // de la 2 la sqrt(number).
    // Dacă number este divizibil de vreunul dintre acești divizori,
    // înseamnă că nu este prim.
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    // Dacă trece de toate testele, este prim.
    return true;
}

Console.WriteLine(IsPrime(5));  // Afișează true, deoarece 5 este prim
Console.WriteLine(IsPrime(10)); // Afișează false, deoarece 10 nu este prim (e divizibil cu 2 și 5)
Console.WriteLine(IsPrime(11)); // Afișează true
Console.WriteLine(IsPrime(1));  // Afișează false
