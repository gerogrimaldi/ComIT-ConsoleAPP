using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2_Clase_Curso
{
    internal class Profesor : Persona
    {
        private int _aniosExp = 0;

        public Profesor(long dni, string nombre, string apellido, DateOnly fechaNac, int aniosExp) 
            : base(dni,nombre,apellido,fechaNac)
        {
            this._aniosExp = aniosExp;
        }
        public int getExp()
        {
            return _aniosExp;
        }
        public override void mostrarDatos()
        {
            Console.WriteLine("\nProfesor: ");
            base.mostrarDatos();
            Console.WriteLine("Años de experiencia: " + this.getExp());
        }
        
    }
}
