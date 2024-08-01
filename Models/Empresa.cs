using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Ssimu_GestionEmpleados.Models;

namespace Ssimu_GestionEmpleados.Models;

public class Empresa
{
    public string Nombre { get; set; }

    public string Direccion { get; set; }
    public List<Empleado> Empleados = new List<Empleado>();
    public List<Cliente> Clientes = new List<Cliente>();


    // Constructor
    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        Empleados = new List<Empleado>();
        Clientes = new List<Cliente>();
    }

    // Metodos Empleado

    public void AgregarEmpleado()
    {   
        Guid id = Guid.NewGuid();
        Console.WriteLine("Nombre del empleado: ");
        string? nombre = Console.ReadLine();
        Console.WriteLine("Apellidos del empleado: ");
        string? apellidos = Console.ReadLine();
        Console.WriteLine("Número de identificación: ");
        string? numeroDeIdentificacion = Console.ReadLine();
        Console.WriteLine("Edad: ");
        byte edad = byte.Parse(Console.ReadLine());
        Console.WriteLine("Posición: ");
        string? posicion = Console.ReadLine();
        Console.WriteLine("Salario: ");
        decimal salario = decimal.Parse(Console.ReadLine());

        Empleado nuevoEmpleado = new Empleado(id, nombre, apellidos, numeroDeIdentificacion, edad, posicion, salario);

        Empleados.Add(nuevoEmpleado);
    }

    public void EliminarEmpleado()
    {
        Console.WriteLine("Numero de identificación del empleado a eliminar: ");
        string numeroDeIdentificacion = Console.ReadLine();

        Empleado empleado = Empleados.Find(e => e.GetNumeroDeIdentificacion() == numeroDeIdentificacion);
        if (empleado != null)
        {
            Console.WriteLine("Este es el empleado que deseas eliminar: ");
            empleado.MostrarInformacion();
            Console.WriteLine("S/N");
            string respuesta = Console.ReadLine();
            if (respuesta == "S" || respuesta == "s")
            {   
                Empleados.Remove(empleado);
                Console.WriteLine("Empleado eliminado correctamente.");
            }
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public void MostrarEmpleados()
    {
        Console.WriteLine("Empleados:");
        foreach (Empleado empleado in Empleados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine();
        }
    }
    /*
    public void ActualizarEmpleado()
    {
        Console.WriteLine("Id del empleado a actualizar: ");
        string? numeroDeIdentificacion = Console.ReadLine();

        Empleado empleado = Empleados.Find(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleado != null)
        {
            Console.WriteLine("Nombre: ");
            string? nombre = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            string? apellidos = Console.ReadLine();
            Console.WriteLine("Edad: ");
            byte edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("Posición: ");
            string? posicion = Console.ReadLine();
            Console.WriteLine("Salario: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            Empleado nuevoEmpleado = new Empleado(empleado.Id, nombre, apellidos, numeroDeIdentificacion, edad, posicion, salario);
            Empleados[Empleados.IndexOf(empleado)] = nuevoEmpleado;
            Console.WriteLine("Empleado actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }
*/
    public void BuscarEmpleado()
    {
        Console.WriteLine("Numero de identificación del empleado a buscar: ");

        string? numeroDeIdentificacion = Console.ReadLine();
        Empleado empleado = Empleados.Find(e => e.GetNumeroDeIdentificacion() == numeroDeIdentificacion);
        if (empleado != null)
        {
            Console.WriteLine("Empleado encontrado: ");
            empleado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine("pleado no encontrado.");
        }
    }

    public void MostrarEmpleadosPorPosicion()
    {
        Console.WriteLine("Posición de los empleados a mostrar: ");
        string? posicion = Console.ReadLine();
        Empleados.FindAll(e => e.Posicion == posicion).
            ForEach(e => e.MostrarInformacion());
    }

    // Metodos Cliente

    public void AgregarCliente(Cliente nuevoCliente)
    {   
        
        Clientes.Add(nuevoCliente);
    }
/*
    public void EliminarCliente()
    {
        Console.WriteLine("Numero de identificación del cliente a eliminar: ");
        string? numeroDeIdentificacion = Console.ReadLine();

        Cliente cliente = Clientes.Find(c => c.GetNumeroDeIdentificacion() == numeroDeIdentificacion);
        if (cliente != null)
        {
            Console.WriteLine("Este es el cliente que deseas eliminar: ");
            cliente.MostrarInformacion();
            Console.WriteLine("S/N");
            string? respuesta = Console.ReadLine();
            if (respuesta == "S" || respuesta == "s")
            {   
                Clientes.Remove(cliente);
                Console.WriteLine("Cliente eliminado correctamente.");
            }
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }
*/
    public void MostrarClientes()
    {
        Console.WriteLine("Clientes:");
        foreach (Cliente cliente in Clientes)
        {
            cliente.MostrarInformacion();
            Console.WriteLine();
        }
    }
}