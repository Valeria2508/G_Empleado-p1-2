using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G_Empleados_p1_p2.models
{
    public class Persona
    {
        // en person se agg los atributos que se le van heredar a los hijos
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroDeIdentificacion { get; set; }
        public byte Edad { get; set; }

        // se crea el metodo 
        public virtual void MostrarInformacion()
        {
            Console.WriteLine(@$"
            Id: {Id}
            Nombre: {Nombre}
            Apellido: {Apellido}
            Número de Identificación: {NumeroDeIdentificacion}
            Edad: {Edad}");
        }
    }
}