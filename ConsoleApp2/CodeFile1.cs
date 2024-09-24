//Crear un método que recibas dos valores, y muestre la
//suma de ambos.
System.consoleapp.WriteLine("\n#############################################\n");
Console.WriteLine("SUMA: ");

void Sumar (int x, int y)
{
    Console.WriteLine($"Suma:  { x + y}");
}

int x, y = 0;

Console.WriteLine("\nIngrese 2 valores para sumar");
x = Convert.ToInt16(Console.ReadLine());
y = Convert.ToInt16(Console.ReadLine());
Sumar(x, y);

