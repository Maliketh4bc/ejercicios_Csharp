using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el valor de un lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());

        double perimetro = 4 * lado;
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
    }
}
