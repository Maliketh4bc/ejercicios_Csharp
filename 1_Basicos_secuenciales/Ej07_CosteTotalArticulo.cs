using System;

class Program
{
    static void Main()
    {
        Console.Write("Precio del artículo: ");
        double precio = double.Parse(Console.ReadLine());
        Console.Write("Cantidad que lleva el cliente: ");
        int cantidad = int.Parse(Console.ReadLine());

        double total = precio * cantidad;
        Console.WriteLine($"El coste total es: {total:F2}€");
    }
}
