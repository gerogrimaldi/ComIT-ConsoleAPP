using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_Clase_Curso
{
    internal class Alumno : Persona
    {
        private bool _trabaja = false;
        public Alumno(long dni, string nombre, string apellido, DateOnly fechaNac, bool trabaja)
                : base(dni, nombre, apellido, fechaNac)
        {
            this._trabaja = trabaja;
        }

        public bool getTrabaja()
        {
            return this._trabaja;
        }
    }
}
