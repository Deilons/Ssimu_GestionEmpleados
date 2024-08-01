using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models;

public class Cliente : Persona
{
    public string Email { get; set; }

    public string Telefono { get; set; }

    public Cliente( Guid id ,string nombre, string apellidos, int edad, string email, string telefono) : base( id,nombre, apellidos, edad)
    {
        Email = email;
        Telefono = telefono;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($@"
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        Edad: {Edad}
        Email: {Email}
        Telefono: {Telefono}
        ");
    }
}
