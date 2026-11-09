using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();

        bool comienzaPorWww = texto.StartsWith("www");
        Console.WriteLine(comienzaPorWww);   // true / false
    }
}
