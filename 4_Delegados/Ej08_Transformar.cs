using System;

delegate int Transformar(int x);

class Program
{
    static int Doblar(int x) { return x * 2; }
    static int Triplicar(int x) { return x * 3; }
    static int Cuadrado(int x) { return x * x; }

    static void Main()
    {
        Console.Write("Introduce un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Transformar transformar = Doblar;
        transformar += Triplicar;
        transformar += Cuadrado;

        foreach (Transformar metodo in transformar.GetInvocationList())
        {
            Console.WriteLine(metodo.Method.Name + ": " + metodo(numero));
        }
    }
}
