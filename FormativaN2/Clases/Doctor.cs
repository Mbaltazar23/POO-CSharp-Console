using System;
using System.Collections.Generic;
using System.Text;

namespace FormativaN2.Clases
{
    class Doctor : Persona
    {
        private string especialidad;

        public Doctor(long rut, string nombre, string direccion, string especialidad) : base(rut, nombre, direccion)
        {
            this.especialidad = especialidad;
        }
    }
}
