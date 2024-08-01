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
        protected string NumeroDeIdentificacion { get; set; }


        public Persona( Guid id ,string nombre, string apellidos, int edad, string numeroDeIdentificacion)
        {   
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            NumeroDeIdentificacion = numeroDeIdentificacion;
        }
        public abstract void MostrarInformacion();
        
        public string GetNumeroDeIdentificacion()
        {
            return NumeroDeIdentificacion;
        }
        public string GetId()
        {
            return Id.ToString();
        }
    }

}