using System;

delegate int Operacion(int x, int y);

class Program
{
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Operacion op = Sumar;   // Asignamos el método al delegado
        Console.WriteLine("Suma: " + op(5, 3));
    }
}
