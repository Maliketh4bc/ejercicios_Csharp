using System;

class Cliente
{
    private string nombre;
    private double cantidadTotal;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
        this.cantidadTotal = 0;
    }

    public void Ingresar(double cantidad)
    {
        if (cantidad > 0)
            cantidadTotal += cantidad;
    }

    public void Sacar(double cantidad)
    {
        if (cantidad > 0 && cantidad <= cantidadTotal)
            cantidadTotal -= cantidad;
        else
            Console.WriteLine($"{nombre}: no se puede sacar {cantidad}€ (saldo insuficiente o cantidad no válida)");
    }

    public double GetCantidadTotal()
    {
        return cantidadTotal;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"{nombre} tiene {cantidadTotal:F2}€ en su cuenta");
    }
}

class Banco
{
    private Cliente cliente1;
    private Cliente cliente2;
    private Cliente cliente3;

    public Banco()
    {
        cliente1 = new Cliente("Ana");
        cliente2 = new Cliente("Luis");
        cliente3 = new Cliente("Marta");
    }

    // Simula el ingreso de dinero en las cuentas de cada cliente
    public void Operar()
    {
        cliente1.Ingresar(1500);
        cliente2.Ingresar(800.50);
        cliente3.Ingresar(2300);
        cliente2.Sacar(300);
    }

    public void ObtenerEstado()
    {
        double total = cliente1.GetCantidadTotal()
                     + cliente2.GetCantidadTotal()
                     + cliente3.GetCantidadTotal();

        Console.WriteLine($"Dinero total en el banco: {total:F2}€");
        Console.WriteLine($"Cliente 1: {cliente1.GetCantidadTotal():F2}€");
        Console.WriteLine($"Cliente 2: {cliente2.GetCantidadTotal():F2}€");
        Console.WriteLine($"Cliente 3: {cliente3.GetCantidadTotal():F2}€");

        cliente1.MostrarInformacion();
        cliente2.MostrarInformacion();
        cliente3.MostrarInformacion();
    }

    static void Main()
    {
        Banco banco = new Banco();
        banco.Operar();
        banco.ObtenerEstado();
    }
}
