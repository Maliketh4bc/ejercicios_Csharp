using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("El factorial no está definido para números negativos.");
            return;
        }

        long factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"{n}! = {factorial}");
    }
}
