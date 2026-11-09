using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"La suma de los dígitos de {n} es {SumaDigitos(n)}");
    }

    static int SumaDigitos(int n)
    {
        if (n < 0)
            n = -n;

        int suma = 0;
        while (n > 0)
        {
            suma += n % 10;   // último dígito
            n /= 10;          // quitamos el último dígito
        }
        return suma;
    }
}
