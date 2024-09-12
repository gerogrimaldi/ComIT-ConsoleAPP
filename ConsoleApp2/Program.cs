using System.Drawing;
using System.Linq.Expressions;
using System.Net;
using System.Text.RegularExpressions;

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

        Array.Resize(ref cadenasConNull, 2);

        //########### EJERCICIOS CLASE 3 ##################

        //Definir una variable numérica, asignarle un valor y sumarle 5.
        int var1 = 0;
        var1 += 5;

        //Definir dos variables de cadenas, asignarles valores y concatenarlas.
        Console.WriteLine("\n#############################################\n");
        string cadena1 = "Hola";
        string cadena2 = "Mundo";
        Console.WriteLine("CADENAS: ");
        Console.WriteLine(cadena1 + " " + cadena2);

        //Evaluar si dos números son iguales, diferentes, mayor o menor.
        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("Ingrese 2 valores");
        
        var1 = Convert.ToInt16(Console.ReadLine());
        int var2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"Var1= {var1} Var2= {var2}");
        Console.WriteLine((var1 != var2) ? "Los numeros NO son iguales" : "Los numeros son iguales"); 
        Console.WriteLine((var1 > var2) ? 
            "var1 es mayor" : (var1 < var2) ? 
            "var2 es mayor" : "Los numeros son iguales");

        //Definir una variable numérica.
        //Asignarle un valor entre 1 y 10
        //Mostrar a que grupo pertenece:

        //Grupo 1: del 1 al 3
        //Grupo 2: del 4 al 6
        //Grupo 3: del 7 al 10
        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("SWITCH: ");

        Console.WriteLine("\nIngrese otro valor");
        var2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"Nueva var2= {var2}");

        switch(var2)
        {
            case int when (var2 <= 3 && var2 > 0):
                Console.WriteLine("Grupo 1");
                break;
            case int when (var2 <= 6 && var2 > 3):
                Console.WriteLine("Grupo 2");
                break;
            case int when (var2 <= 10 && var2 > 6):
                Console.WriteLine("Grupo 3");
                break;
            default:
                Console.WriteLine("Ningun grupo");
                break;
        }


        //Realizar la sumatoria de 0 a 10 y devolver el valor de la misma.
        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("WHILE: ");

        int n = 0;
        while (n < 10)
        {
            n+=1;
        }
            Console.WriteLine($"Sumatoria: {n}");

        //Generar un array con 10 números, 
        //recorrerlo e ir multiplicando todos los elementos, 
        //finalmente obtener elproducto total.
        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("ARRAY: ");

        int[] numeros = new int[] { 1, 2, 3, 4, 5 ,6, 7, 8, 9, 10};
        n = 1;
        foreach (int nro in numeros)
        {
            n *= nro;
        }
        Console.WriteLine($"Factorial de 10: {n}");
    }
}