using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
            Console.WriteLine("El factorial no está definido para números negativos.");
        else
            Console.WriteLine($"{n}! = {Factorial(n)}");
    }

    // n! = n * (n-1)!   con caso base 0! = 1! = 1
    static long Factorial(int n)
    {
        if (n <= 1)
            return 1;
        return n * Factorial(n - 1);
    }
}
