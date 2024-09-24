
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net;

internal class Metodos
{
    private static void Main(string[] args)
    {
        //Crear un método que recibas dos valores, y muestre la
        //suma de ambos.
        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("SUMA: ");

        void Sumar(int x, int y)
        {
            Console.WriteLine($"Suma:  {x + y}");
        }

        Console.WriteLine("\nIngrese 2 valores para sumar");
        int x = Convert.ToInt16(Console.ReadLine());
        int y = Convert.ToInt16(Console.ReadLine());
        Sumar(x, y);


        //2.Crear una función que reciba dos cadenas de texto y
        //retorne la concatenación de las mismas

        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("CADENAS: ");

        string Concatenar(string? str1, string? str2)
        {
            return str1+str2;
        }

        Console.WriteLine("\nIngrese 2 cadenas para concatenar");
        string? str1 = Console.ReadLine();
        string? str2= Console.ReadLine();
        Console.WriteLine($"Cadenas concatenadas: {Concatenar(str1,str2)}");

        //3.Crear una función que reciba dos valores: cantidad y
        //precio unitario. Si el total del ítem es mayor a 1000,
        //aplicar un 10 % de descuento.Devolver el valor total del
        //ítem.

        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("Calcular total: ");

        float CalcTotal (int cant, float precio)
        {
            if (precio.Equals(null)) { precio = 0; }; //valido precio

            float total = cant * precio;
            if(total > 1000)
            {
                Console.WriteLine("\nAplico descuento 10%");
                return total - (10*(total)/100);
            }

            return total;

        }

        Console.WriteLine("\nIngrese cantidad: ");
        int cant = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("\nIngrese precio unitario: ");
        float precio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat); //recibe la coma como separador decimal

        Console.WriteLine($"Total: {CalcTotal(cant, precio)}");

        //4. Crear una función que reciba un número y muestre tantos
        //asteriscos como la cantidad de veces que se pasó como
        //parámetro.EJ: 5 🡪 *****
        Console.WriteLine("\n#############################################\n");
        Console.WriteLine("Asteriscos: ");

        void Asteriscos(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
        }

        Console.WriteLine("\nIngrese cantidad: ");
        cant = Convert.ToInt16(Console.ReadLine());

        Asteriscos(cant); 

    }
}
      