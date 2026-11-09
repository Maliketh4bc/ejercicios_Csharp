using System;

class Program
{
    static void Main()
    {
        Console.Write("Tamaño del array: ");
        int tamano = int.Parse(Console.ReadLine());
        int[] numeros = new int[tamano];

        for (int i = 0; i < tamano; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores pares:");
        foreach (int n in numeros)
            if (n % 2 == 0)
                Console.Write(n + " ");

        Console.WriteLine();
        Console.WriteLine("Valores impares:");
        foreach (int n in numeros)
            if (n % 2 != 0)
                Console.Write(n + " ");

        Console.WriteLine();
    }
}
