using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G_Empleados_p1_p2.models
{
    public class Empleado : Persona
    {
         // atributos de empleado
        public string? Posicion { get; set; }
        public decimal Salario { get; set; }


        public Empleado(string nombre, string apellido, string numeroDeDocumento, byte edad, string posicion, decimal salario)
        {
            Id = new Guid();
            Nombre = nombre;
            Apellido = apellido;
            NumeroDeIdentificacion = numeroDeDocumento;
            Edad = edad;
            Posicion = posicion;
            Salario = salario;

        }

        private decimal CalcularBonificacion()
        {
            var Bonificacion = Salario * Convert.ToDecimal(0.01);
            var SalarioBonificacion = Bonificacion + Salario;
            return SalarioBonificacion;
        }

        // sobre escritura de metodos
        public override void MostrarInformacion()
        {
            Console.WriteLine(@$"
            Id: {Id}
            Nombre: {Nombre}
            Apellido: {Apellido}
            Número de Identificación: {NumeroDeIdentificacion}
            Edad: {Edad}
            Posición: {Posicion}
            Salario base: {Salario}
            Salario con Bonificación: {CalcularBonificacion()}
            ");
        }
    }
}