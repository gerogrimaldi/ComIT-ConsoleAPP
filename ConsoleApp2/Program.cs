internal class Program
{
    private static void Main(string[] args)
    {
        string nombre;
        nombre = "Geronimo";
        bool estaNublado = true;
        char letra = 'c';
        DateTime fecha = DateTime.Now;
        DateOnly fechaSolo;
        TimeOnly horaSolo;

        const string constanteSaludo = "Buen dia";
        string saludo;

        if (estaNublado)
        {
            string apellido = "Grimaldi";
            if (letra == 'c')
            {
                apellido = "Ramirez";
            }
            saludo = "Hola " + nombre + " " + apellido + "!. Hoy no es un buen dia!"; 
        }
        else
        {
            string sobreNombre = "gero";
            saludo = "Hola " + sobreNombre + "!. Que lindo dia hoy";
        }

        Console.WriteLine(saludo);

        int numero1 = 10;
        int numero2 = 20;

        Console.WriteLine($"La suma de {numero1} + {numero2} es de {numero1 + numero2,10}");

        string?[] cadenasConNull = new string?[5] { "Uno", "", null, "Cuatro", "Cinco" };
        Console.WriteLine("FOREACH");
        foreach (var item in cadenasConNull)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\noperador condicional");
        foreach (var item in cadenasConNull)
        {
            //Console.WriteLine(item == null ? "Sin valor" : item);
            Console.WriteLine(item ?? "Sin Valor");
        }
    }
}