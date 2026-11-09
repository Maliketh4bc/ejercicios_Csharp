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

        int suma = 0;
        foreach (int n in numeros)
            suma += n;

        double media = tamano > 0 ? (double)suma / tamano : 0;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Media: {media:F2}");
    }
}
