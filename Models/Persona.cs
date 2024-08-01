using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models
{
    public abstract class Persona
    {

        protected Guid Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellidos { get; set; }
        protected int Edad  { get; set; }

        public Persona( Guid id ,string nombre, string apellidos, int edad)
        {   
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }
        public abstract void MostrarInformacion();
        
    }

}