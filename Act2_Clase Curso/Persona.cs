using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_Clase_Curso
{
    internal class Persona
    {
        protected long _dni;
        protected string _nombre = "";
        protected string _apellido = "";
        protected DateOnly _fechaNac = new ();

        public Persona(long dni, string nombre, string apellido, DateOnly fechaNac)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fechaNac;
        }
        
        //######### GETTERS ###########
        public string getNombre()
        {
            return _nombre + _apellido;
        }
        public long getDni()
        {
            return _dni;
        }
        public DateOnly getfechaNac()
        {
            return _fechaNac;
        }
       
        public virtual void mostrarDatos()
        {
            Console.WriteLine("Nombre: "+ this._nombre + " " + this._apellido);
            Console.WriteLine("DNI: "+ this._dni);
            Console.WriteLine("Fecha Nacimiento: "+ this._fechaNac);
            //Console.WriteLine("Edad: "+ this.calcularEdad());

        }

        //### Calculos 
        public int calcularEdad()
        {
            int edad = DateTime.Today.Year - _fechaNac.Year;

            // Si la persona no ha cumplido años este año, restamos 1
            if (DateTime.Today.CompareTo(_fechaNac.AddYears(edad)) < 0)
            {
                edad--;
            }

            return edad;
        }
    }
}
