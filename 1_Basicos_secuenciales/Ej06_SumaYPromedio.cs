using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Introduce el valor {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"El promedio es: {suma / 4}");
    }
}
