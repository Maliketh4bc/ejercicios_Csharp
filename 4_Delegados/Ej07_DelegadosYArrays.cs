using System;

delegate int OperarArray(int[] numeros);

class Program
{
    static int Suma(int[] numeros)
    {
        int suma = 0;
        foreach (int n in numeros)
            suma += n;
        return suma;
    }

    static int Multiplicar(int[] numeros)
    {
        int producto = 1;
        foreach (int n in numeros)
            producto *= n;
        return producto;
    }

    static void Main()
    {
        int[] numeros = { 2, 3, 4, 5 };

        OperarArray op = Suma;
        op += Multiplicar;   // Restar queda descartado en este ejercicio

        foreach (OperarArray metodo in op.GetInvocationList())
        {
            Console.WriteLine(metodo.Method.Name + ": " + metodo(numeros));
        }
    }
}
