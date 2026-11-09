using System;

class Program
{
    static void Main()
    {
        Console.Write("Número 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Número 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Número 3: ");
        double n3 = double.Parse(Console.ReadLine());
        Console.Write("Número 4: ");
        double n4 = double.Parse(Console.ReadLine());

        Console.WriteLine($"La suma de los dos primeros es: {n1 + n2}");
        Console.WriteLine($"El producto del tercero y el cuarto es: {n3 * n4}");
    }
}
