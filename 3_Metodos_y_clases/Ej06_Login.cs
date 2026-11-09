using System;

class Program
{
    const int MAX_INTENTOS = 3;

    static void Main()
    {
        int intentos = 0;
        bool acceso = false;

        while (intentos < MAX_INTENTOS && !acceso)
        {
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string password = Console.ReadLine();

            acceso = Login(usuario, password);
            intentos++;

            if (!acceso)
                Console.WriteLine($"Credenciales incorrectas. Intentos restantes: {MAX_INTENTOS - intentos}");
        }

        if (acceso)
            Console.WriteLine("Login correcto. ¡Bienvenido!");
        else
            Console.WriteLine("Has agotado los tres intentos. Acceso denegado.");
    }

    static bool Login(string usuario, string password)
    {
        return usuario == "usuario2DAM" && password == "pass2DAM";
    }
}
