using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models;

public class Cliente : Persona
{
    public string Email { get; set; }

    public string Telefono { get; set; }

    public Cliente(Guid id ,string nombre, string apellidos, int edad, string NumeroDeIdentificacion,string email, string telefono) : base( id,nombre, apellidos, edad, NumeroDeIdentificacion)
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
        Número de identificación: {NumeroDeIdentificacion}
        Email: {Email}
        Telefono: {Telefono}
        ");
    }
}
