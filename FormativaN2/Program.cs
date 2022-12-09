using FormativaN2.Clases;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace FormativaN2
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new Doctor(194540546, "Juanito", "Las Petunias", "Quimioterapia");
            Paciente paci = new Paciente(120000, "Mario", "Abelardo Nuñez", new MyDate(28, 2, 2020));
            paci.diagnosticar("Covid-19");
            Console.WriteLine("El diagnostico del Paciente es : {0} ", paci.getDiagnostico());
            paci.getFechaIngreso().mostrarFecha();
            paci.getFechaIngreso().setDay(23);
            paci.getFechaIngreso().setMonth(2);
            paci.getFechaIngreso().setYear(2000);
            paci.getFechaIngreso().mostrarFecha();
        }

    }
}
