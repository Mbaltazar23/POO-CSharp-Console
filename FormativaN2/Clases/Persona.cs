using System;
using System.Collections.Generic;
using System.Text;

namespace FormativaN2.Clases
{
    class Persona
    {
        protected long rut;
        protected string nombre;
        protected string direccion;

        public Persona(long rut, string nombre, string direccion)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
}
