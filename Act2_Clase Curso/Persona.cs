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
        protected string _nombre = string.Empty;
        protected string _apellido = string.Empty;
        protected DateOnly _fechaNac = new ();

        public Persona(long dni, string nombre, string apellido, DateOnly fechaNac)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fechaNac;
        }
        
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
    }
}
