using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_Clase_Curso
{
    internal class Curso
    {
        private string _nombre = string.Empty;
        private int _cantMaxAlumnos = 0;
        private Profesor? _Profesor;
        private Alumno[]? _Alumnos;

        //### METODOS #####
        public Curso (string nombre, int n,  Profesor? profesor)
        {
            this._nombre = nombre;
            this._cantMaxAlumnos = n;
            this._Profesor = profesor; //constructor de copia. Tambien puedo llamar a cambiarProfesor()
            this._Alumnos = new Alumno[n]; 
        }
        //Carga de datos / SETTERS
        public void agregarAlumno(long dni, string nombre, string apellido, DateOnly fechaNac, bool trabaja, int pos)
        {
            _Alumnos[pos]= new Alumno(dni, nombre, apellido, fechaNac, trabaja);
        }

        public void cambiarProfesor(Profesor? profesor)
        {
            this._Profesor = profesor;
        }

        public void mostrarCurso()
        {
            Console.WriteLine("Curso: " + this.getNombre());
        }

        //GETTERS
        public string getNombre()
        {
            return this._nombre;
        }
    }

}
