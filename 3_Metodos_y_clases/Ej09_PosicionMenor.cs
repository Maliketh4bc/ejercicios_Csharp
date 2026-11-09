using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 14, 8, 23, 5, 17, 9, 31 };

        int posicion = PosicionMenor(numeros);
        Console.WriteLine($"El número menor es {numeros[posicion]} y está en la posición {posicion}");
    }

    static int PosicionMenor(int[] array)
    {
        int posicion = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[posicion])
                posicion = i;
        }
        return posicion;
    }
}
