using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una cadena: ");
        string texto = Console.ReadLine();

        Console.WriteLine($"Número de espacios en blanco: {ContarEspacios(texto)}");
    }

    // Recibe un string y devuelve el número de espacios en blanco
    static int ContarEspacios(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if (c == ' ')
                contador++;
        }
        return contador;
    }
}
