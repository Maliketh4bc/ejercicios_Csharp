using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Kilowatios consumidos en el período anterior: ");
        double kw = double.Parse(Console.ReadLine());

        double precioKw;
        if (kw > 1800)
            precioKw = 0.8;
        else if (kw >= 1000)      // entre 1000 y 1800
            precioKw = 0.12;
        else                      // menos de 1000
            precioKw = 0.14;

        double total = kw * precioKw;

        // Formato moneda (euros, con coma decimal)
        Console.WriteLine($"Total a pagar: {total.ToString("C2", new CultureInfo("es-ES"))}");
    }
}
