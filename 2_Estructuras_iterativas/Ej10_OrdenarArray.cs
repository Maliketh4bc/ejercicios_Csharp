using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 42, 7, 19, 3, 88, 25, 61, 1, 54, 33 };

        Array.Sort(numeros);

        Console.WriteLine("Valores ordenados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
