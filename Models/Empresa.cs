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

    // Constructor
    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        Empleados = new List<Empleado>();
    }

    // Metodos

    public void AgregarEmpleado(Empleado empleado)
    {   
        int id = Empleados.Count + 1;
        Console.WriteLine("Nombre del empleado: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Apellidos del empleado: ");
        string apellidos = Console.ReadLine();
        Console.WriteLine("Número de identificación: ");
        string numeroDeIdentificacion = Console.ReadLine();
        Console.WriteLine("Edad: ");
        byte edad = byte.Parse(Console.ReadLine());
        Console.WriteLine("Posición: ");
        string posicion = Console.ReadLine();
        Console.WriteLine("Salario: ");
        double salario = double.Parse(Console.ReadLine());

        Empleado nuevoEmpleado = new Empleado(id, nombre, apellidos, numeroDeIdentificacion, edad, posicion, salario);

        Empleados.Add(nuevoEmpleado);
    }

    public void EliminarEmpleado()
    {
        Console.WriteLine("Id del empleado a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        Empleado empleado = Empleados.Find(e => e.Id == id);
        if (empleado != null)
        {
            Empleados.Remove(empleado);
            Console.WriteLine("Empleado eliminado correctamente.");
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
    public void ActualizarEmpleado()
    {
        Console.WriteLine("Id del empleado a actualizar: ");
        int id = int.Parse(Console.ReadLine());

        Empleado empleado = Empleados.Find(e => e.Id == id);
        if (empleado != null)
        {
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Número de identificación: ");
            string numeroDeIdentificacion = Console.ReadLine();
            Console.WriteLine("Edad: ");
            byte edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("Posición: ");
            string posicion = Console.ReadLine();
            Console.WriteLine("Salario: ");
            double salario = double.Parse(Console.ReadLine());

            Empleado nuevoEmpleado = new Empleado(id, nombre, apellidos, numeroDeIdentificacion, edad, posicion, salario);
            Empleados[Empleados.IndexOf(empleado)] = nuevoEmpleado;
            Console.WriteLine("Empleado actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public void BuscarEmpleado()
    {
        Console.WriteLine("Numero de identificación del empleado a buscar: ");

        string numeroDeIdentificacion = Console.ReadLine();
        Empleado empleado = Empleados.Find(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
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
        string posicion = Console.ReadLine();
        Empleados.FindAll(e => e.Posicion == posicion).
            ForEach(e => e.MostrarInformacion());
    }

}


