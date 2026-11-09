using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"La suma es {numero1 + numero2}");
        Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
        Console.WriteLine($"La división es: {Math.Truncate(numero1 / numero2)}");
        Console.WriteLine($"El módulo es: {numero1 % numero2}");
    }
}
