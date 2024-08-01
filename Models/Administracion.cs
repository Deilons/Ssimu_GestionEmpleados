using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models;

public static class Administracion
{
    public static Cliente CrearCliente()
    {
        Guid id = Guid.NewGuid();
        Console.WriteLine("Nombre del cliente: ");
        string? nombre = Console.ReadLine();
        Console.WriteLine("Apellidos del cliente: ");
        string? apellidos = Console.ReadLine();
        Console.WriteLine("Edad: ");
        byte edad = byte.Parse(Console.ReadLine());
        Console.WriteLine("Email: ");
        string? email = Console.ReadLine();
        Console.WriteLine("Teléfono: ");
        string? telefono = Console.ReadLine();

        Cliente nuevoCliente = new Cliente(id, nombre, apellidos, edad, email, telefono);

        return nuevoCliente;
        }
}
