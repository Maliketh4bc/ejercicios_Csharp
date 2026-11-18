using System;

delegate double Calculo(double x);

class Program
{
    static double RaizCuadrada(double x)
    {
        // Math.Sqrt no lanza excepción con negativos (devuelve NaN), así que la lanzamos nosotros
        if (x < 0)
            throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
        return Math.Sqrt(x);
    }

    static double Logaritmo(double x)
    {
        // Math.Log tampoco lanza excepción con 0 o negativos
        if (x <= 0)
            throw new ArgumentException("El logaritmo solo existe para números mayores que 0.");
        return Math.Log(x);   // Logaritmo neperiano
    }

    static void EjecutarCalculo(Calculo calculo, double numero)
    {
        try
        {
            double resultado = calculo(numero);
            Console.WriteLine($"{calculo.Method.Name}({numero}) = {resultado:F4}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void Main()
    {
        EjecutarCalculo(RaizCuadrada, 16);
        EjecutarCalculo(RaizCuadrada, -4);
        EjecutarCalculo(Logaritmo, 10);
        EjecutarCalculo(Logaritmo, 0);
    }
}
