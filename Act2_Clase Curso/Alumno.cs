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

        //##########GETTERS######
        public bool getTrabaja()
        {
            return this._trabaja;
        }
        public string str_trabaja()
        {
            return this._trabaja ? "Si" : "No";
        }
        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Trabaja: " + this.str_trabaja());
        }
    }
}
