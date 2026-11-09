using System;

class Program
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("Introduce un número del 1 al 9: ");
            numero = int.Parse(Console.ReadLine());
            if (numero < 1 || numero > 9)
                Console.WriteLine("Número fuera de rango, inténtalo de nuevo.");
        } while (numero < 1 || numero > 9);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
