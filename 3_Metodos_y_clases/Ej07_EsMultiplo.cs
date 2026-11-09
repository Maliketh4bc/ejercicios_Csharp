using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        if (EsMultiplo(a, b))
            Console.WriteLine($"{a} es múltiplo de {b}");
        else if (EsMultiplo(b, a))
            Console.WriteLine($"{b} es múltiplo de {a}");
        else
            Console.WriteLine("Ninguno de los dos es múltiplo del otro");
    }

    // Devuelve true si el primero es múltiplo del segundo
    static bool EsMultiplo(int primero, int segundo)
    {
        if (segundo == 0)
            return false;
        return primero % segundo == 0;
    }
}
