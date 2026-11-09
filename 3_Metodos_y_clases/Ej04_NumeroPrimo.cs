using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int n = int.Parse(Console.ReadLine());

        if (EsPrimo(n))
            Console.WriteLine($"{n} es primo");
        else
            Console.WriteLine($"{n} NO es primo");
    }

    static bool EsPrimo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
