using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        double numero = double.Parse(Console.ReadLine());

        // Para Max y Min necesitamos un segundo número (lo definimos por código)
        double otro = 10;

        Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
        Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
        Console.WriteLine($"Seno: {Math.Sin(numero)}");
        Console.WriteLine($"Coseno: {Math.Cos(numero)}");
        Console.WriteLine($"Número máximo entre {numero} y {otro}: {Math.Max(numero, otro)}");
        Console.WriteLine($"Número mínimo entre {numero} y {otro}: {Math.Min(numero, otro)}");
    }
}
