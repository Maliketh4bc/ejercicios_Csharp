using System;

class Program
{
    static void Main()
    {
        Console.Write("Aportación del socio 1: ");
        double aporte1 = double.Parse(Console.ReadLine());
        Console.Write("Aportación del socio 2: ");
        double aporte2 = double.Parse(Console.ReadLine());
        Console.Write("Aportación del socio 3: ");
        double aporte3 = double.Parse(Console.ReadLine());

        double total = aporte1 + aporte2 + aporte3;
        double p1 = aporte1 * 100 / total;
        double p2 = aporte2 * 100 / total;
        double p3 = aporte3 * 100 / total;

        // Llaves de sustitución en la misma línea
        Console.WriteLine("El porcentaje del socio 1 es {0:F2}%, del socio 2 es {1:F2}% y del socio 3 es {2:F2}%", p1, p2, p3);
    }
}
