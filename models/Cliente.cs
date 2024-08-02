using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G_Empleados_p1_p2.models
{
    public class Cliente: Persona
    {
        public string? Email { get; set; }
        public string? Telefono { get; set; }


        public Cliente(string nombre, string apellido, string numeroDeDocumento, byte edad,string email, string telefono) 
        {
            Id = Guid.NewGuid();  // generar un id unico para cada cliente
            Nombre= nombre;
            Apellido = apellido;
            NumeroDeIdentificacion = numeroDeDocumento;
            Edad = edad;
            Email = email;
            Telefono = telefono;
        }
        public override void MostrarInformacion(){
            Console.WriteLine(@$"
            Id: {Id}
            Nombre: {Nombre}
            Apellido: {Apellido}
            Número de Identificación: {NumeroDeIdentificacion}
            Edad: {Edad}
            Email: {Email}
            Telefono: {Telefono}");
        }
    }
}