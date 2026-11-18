using System;

delegate int OperacionCallback(int x, int y);

class Program
{
    static int Suma(int a, int b) { return a + b; }
    static int Resta(int a, int b) { return a - b; }
    static int Multiplicar(int a, int b) { return a * b; }

    // Acepta un delegado y dos enteros, realiza la operación y devuelve el resultado
    static int EjecutarOperacion(OperacionCallback op, int x, int y)
    {
        return op(x, y);
    }

    static void Main()
    {
        Console.WriteLine("Suma: " + EjecutarOperacion(Suma, 5, 3));
        Console.WriteLine("Resta: " + EjecutarOperacion(Resta, 5, 3));
        Console.WriteLine("Multiplicación: " + EjecutarOperacion(Multiplicar, 5, 3));
    }
}
