using System;

delegate int Operacion(int x, int y);

class Program
{
    static int Sumar(int a, int b) { return a + b; }
    static int Restar(int a, int b) { return a - b; }
    static int Multiplicar(int a, int b) { return a * b; }

    // Recibe un delegado y dos enteros, llama al delegado e imprime el resultado
    static void MostrarResultado(Operacion op, int a, int b)
    {
        Console.WriteLine("Resultado: " + op(a, b));
    }

    static void Main()
    {
        MostrarResultado(Sumar, 5, 3);
        MostrarResultado(Restar, 5, 3);
        MostrarResultado(Multiplicar, 5, 3);
    }
}
