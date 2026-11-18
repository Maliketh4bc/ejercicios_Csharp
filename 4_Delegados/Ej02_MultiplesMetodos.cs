using System;

delegate int Operacion(int x, int y);

class Program
{
    static int Sumar(int a, int b) { return a + b; }
    static int Restar(int a, int b) { return a - b; }

    static void Main()
    {
        Operacion op = Sumar;
        Console.WriteLine("Suma: " + op(5, 3));

        op = Restar;            // Reasignamos el mismo delegado
        Console.WriteLine("Resta: " + op(5, 3));
    }
}
