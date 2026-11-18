using System;

delegate int Operacion(int x, int y);

class Program
{
    static int Sumar(int a, int b) { return a + b; }
    static int Restar(int a, int b) { return a - b; }
    static int Multiplicar(int a, int b) { return a * b; }
    static int Dividir(int a, int b) { return a / b; }

    static void Main()
    {
        Operacion op = Sumar;
        op += Restar;
        op += Multiplicar;
        op += Dividir;

        // Probamos con un divisor normal y con cero
        int[] divisores = { 2, 0 };
        foreach (int b in divisores)
        {
            Console.WriteLine($"\n--- a = 10, b = {b} ---");
            foreach (Operacion metodo in op.GetInvocationList())
            {
                try
                {
                    Console.WriteLine($"{metodo.Method.Name}: {metodo(10, b)}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"{metodo.Method.Name}: Error, no se puede dividir entre cero");
                }
            }
        }
    }
}
