using System;

class Program
{
    // Precios fijados mediante constantes
    const double PRECIO_HAMBURGUESA = 4.50;
    const double PRECIO_PAPAS = 1.75;
    const double PRECIO_BEBIDA = 1.50;

    static void Main()
    {
        Console.Write("Cantidad de hamburguesas: ");
        int hamburguesas = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de papas: ");
        int papas = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de bebidas: ");
        int bebidas = int.Parse(Console.ReadLine());

        double total = hamburguesas * PRECIO_HAMBURGUESA
                     + papas * PRECIO_PAPAS
                     + bebidas * PRECIO_BEBIDA;

        Console.WriteLine($"Cantidad a pagar: {total:F2}€");
    }
}
