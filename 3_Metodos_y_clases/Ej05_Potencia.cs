using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce la base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Introduce el exponente (entero): ");
        int exponente = int.Parse(Console.ReadLine());

        Console.WriteLine($"Iterativa: {baseNum}^{exponente} = {PotenciaIterativa(baseNum, exponente)}");
        Console.WriteLine($"Recursiva: {baseNum}^{exponente} = {PotenciaRecursiva(baseNum, exponente)}");
    }

    static double PotenciaIterativa(double baseNum, int exponente)
    {
        int exp = exponente < 0 ? -exponente : exponente;
        double resultado = 1;
        for (int i = 0; i < exp; i++)
        {
            resultado *= baseNum;
        }
        return exponente < 0 ? 1 / resultado : resultado;
    }

    static double PotenciaRecursiva(double baseNum, int exponente)
    {
        if (exponente < 0)
            return 1 / PotenciaRecursiva(baseNum, -exponente);
        if (exponente == 0)
            return 1;
        return baseNum * PotenciaRecursiva(baseNum, exponente - 1);
    }
}
