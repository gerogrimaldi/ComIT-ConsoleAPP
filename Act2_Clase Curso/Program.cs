//Ejercicio para aplicar los conocimientos de clases y objetos en C#

//Agregar la siguiente funcionalidad:
//-Se permite la carga de N cursos. Si no se ingresa un nombre de curso, finalizar la carga.
//- Por cada curso, cargar N alumnos.
//- Validar que no se permitan cargar mas alumnos de los indicados como máximo en el curso.
//- Listar todos los cursos, mostrando tambien la lista de alumnos de cada uno.

using Act2_Clase_Curso;
using System.IO.IsolatedStorage;

internal class Program
{
    private static void Main(string[] args)
    {

        //CARGA PROFESOR
        //ponemos el mismo profe en todos los cursos para agilizar el testing
        Profesor profesor1 = new Profesor(33445566, "Martin", "Comparetto", new DateOnly(1980, 10, 1), 10);
        
        // CARGA CURSO
        string? nombreCurso = "n";
        int n;

        List<Curso> cursos = new List<Curso>(0);

        while (!string.IsNullOrEmpty(nombreCurso))
        {
            Console.WriteLine("Ingrese un nombre para el curso: \n" +
                "(deje en blanco para finalizar la carga)");
            nombreCurso = Console.ReadLine();


            if (!string.IsNullOrEmpty(nombreCurso))
            {
                Console.WriteLine("Ingrese tamaño maximo del curso: ");
                n = Convert.ToInt32(Console.ReadLine());

                Curso c = new Curso(nombreCurso, n, profesor1);

                // CARGA ALUMNOS
                Console.WriteLine("\nIngreso de alumnos");
                string nombre = "", apellido = "";
                long dni = 0; DateOnly fechaNac;
                bool trabaja = false;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nAlumno " + (i+1));
                    Console.WriteLine("Nombre: " +
                    "(deje en blanco para finalizar la carga)");
                    nombre = Console.ReadLine();

                    if (!string.IsNullOrEmpty(nombre))
                    {
                        Console.WriteLine("Apellido: ");
                        apellido = Console.ReadLine();
                        Console.WriteLine("DNI: ");
                        dni = long.Parse(Console.ReadLine());
                        Console.WriteLine("Trabaja? (SI/NO)");
                        trabaja = Console.ReadLine() == "SI";

                        fechaNac = new DateOnly(2000 + i, 10, 10); //fecha nacimiento la generamos automaticamente

                        //agrego alumno
                        c.agregarAlumno(dni, nombre, apellido, fechaNac, trabaja, i);
                    }
                    else
                    {
                        Console.WriteLine("Finalizo la carga de alumnos");
                        Console.WriteLine("\nSiguiente curso: ");
                        break;
                    }

                }

                //añado curso a la lista de cursos
                cursos.Add(c);

            }
            else
            {
                Console.WriteLine("Finalizo la carga de datos");
                //break;
            }
        }

        foreach (Curso c in cursos)
        {
            Console.WriteLine("\n#####################################");
            c.mostrarCurso();
        }

    }
}