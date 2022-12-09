using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Transactions;

namespace FormativaN2.Clases
{
    class Paciente : Persona
    {
        private MyDate fechaIngreso;
        private string diagnostico;

        public Paciente(long rut, string direccion, string nombre, MyDate fecha) : base(rut, nombre, direccion)
        {
            this.fechaIngreso = fecha;
        }

        public void diagnosticar(string diagnostico)
        {
            this.diagnostico = diagnostico;
        }

        public string getDiagnostico()
        {
            return this.diagnostico;
        }
        public void setFechaIngreso(MyDate fecha)
        {
            this.fechaIngreso = fecha;
        }
        public MyDate getFechaIngreso()
        {
            return this.fechaIngreso;
        }
    }
}
