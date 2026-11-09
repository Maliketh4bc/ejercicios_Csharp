using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack pila = new Stack();

        Console.Write("¿Cuántos valores quieres introducir? ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            pila.Push(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Contenido de la pila (de la cima a la base):");
        MostrarPila(pila);

        // Sacamos un par de elementos (si hay suficientes)
        for (int i = 0; i < 2 && pila.Count > 0; i++)
        {
            Console.WriteLine($"Pop -> {pila.Pop()}");
        }

        Console.WriteLine("Contenido de la pila tras sacar dos elementos:");
        MostrarPila(pila);
    }

    static void MostrarPila(Stack pila)
    {
        foreach (object valor in pila)
            Console.WriteLine(valor);
    }
}
