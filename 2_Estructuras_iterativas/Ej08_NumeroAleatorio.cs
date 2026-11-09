using System;

class Program
{
    static void Main()
    {
        Random aleatorio = new Random();
        // El límite superior de Next es exclusivo, por eso 31
        int numero = aleatorio.Next(10, 31);
        Console.WriteLine($"Número aleatorio entre 10 y 30: {numero}");
    }
}
