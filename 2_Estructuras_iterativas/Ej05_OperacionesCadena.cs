using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine($"Longitud: {texto.Length}");

        Console.Write("Subcadena a buscar: ");
        string subcadena = Console.ReadLine();
        Console.WriteLine($"¿Contiene \"{subcadena}\"? {texto.Contains(subcadena)}");

        Console.Write("Letra a reemplazar: ");
        char viejo = Console.ReadLine()[0];
        Console.Write("Letra nueva: ");
        char nuevo = Console.ReadLine()[0];
        Console.WriteLine($"Reemplazo: {texto.Replace(viejo, nuevo)}");

        Console.WriteLine($"Mayúsculas: {texto.ToUpper()}");
        Console.WriteLine($"Minúsculas: {texto.ToLower()}");

        Console.Write($"Posición del carácter a eliminar (0-{texto.Length - 1}): ");
        int posEliminar = int.Parse(Console.ReadLine());
        if (posEliminar >= 0 && posEliminar < texto.Length)
            Console.WriteLine($"Sin ese carácter: {texto.Remove(posEliminar, 1)}");
        else
            Console.WriteLine("Posición fuera de rango.");

        Console.Write("Posición de inicio de la subcadena: ");
        int inicio = int.Parse(Console.ReadLine());
        Console.Write("Posición de fin de la subcadena: ");
        int fin = int.Parse(Console.ReadLine());
        if (inicio >= 0 && fin >= inicio && fin < texto.Length)
            Console.WriteLine($"Subcadena: {texto.Substring(inicio, fin - inicio + 1)}");
        else
            Console.WriteLine("Posiciones fuera de rango.");
    }
}
