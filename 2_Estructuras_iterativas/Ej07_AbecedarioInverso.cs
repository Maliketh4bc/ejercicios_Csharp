using System;

class Program
{
    static void Main()
    {
        // ASCII: Z = 90, A = 65
        for (int codigo = 90; codigo >= 65; codigo--)
        {
            Console.Write(Convert.ToString((char)codigo) + " ");
        }
        Console.WriteLine();
    }
}
