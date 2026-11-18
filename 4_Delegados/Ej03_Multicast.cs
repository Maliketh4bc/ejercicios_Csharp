using System;

delegate int Operacion(int x, int y);

class Program
{
    static int Sumar(int a, int b) { return a + b; }
    static int Restar(int a, int b) { return a - b; }
    static int Multiplicar(int a, int b) { return a * b; }

    static void Main()
    {
        Operacion op = Sumar;
        op += Restar;
        op += Multiplicar;

        // Llamar a op(5, 3) directamente solo devolvería el resultado del último método,
        // por eso recorremos la lista de invocación para obtener todos los resultados.
        foreach (Operacion metodo in op.GetInvocationList())
        {
            Console.WriteLine("Resultado: " + metodo(5, 3));
        }
    }
}
