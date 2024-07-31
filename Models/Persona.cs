using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad  { get; set; }

        public Persona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($@"
            Nombre: {Nombre}
            Apellidos: {Apellidos}
            Edad: {Edad}
            ");
        }
    }

}