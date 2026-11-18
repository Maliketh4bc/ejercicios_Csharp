using System;

delegate int Operar(int x, int y);

class Program
{
    static int Suma(int a, int b) { return a + b; }
    static int Resta(int a, int b) { return a - b; }
    static int Multiplicacion(int a, int b) { return a * b; }

    static void Main()
    {
        Operar op = Suma;
        op += Resta;
        op += Multiplicacion;

        foreach (Operar metodo in op.GetInvocationList())
        {
            // Method.Name devuelve el nombre del método al que apunta el delegado
            Console.WriteLine(metodo.Method.Name + ": " + metodo(5, 3));
        }
    }
}
