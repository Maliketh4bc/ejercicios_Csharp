using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("Los dos números son iguales");
        }
        else
        {
            // Una sola línea de WriteLine, sin concatenaciones
            Console.WriteLine("El mayor de {0} y {1} es {2}", a, b, a > b ? a : b);
        }
    }
}
