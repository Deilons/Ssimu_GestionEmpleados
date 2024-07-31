using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models;

public class Empleado : Persona
{
    
    public Guid Id = Guid.NewGuid();
    public string NumeroDeIdentificacion { get; set; }
    public string Posicion { get; set; }
    public double Salario { get; set; }

    public Empleado(Guid id, string nombre, string apellidos, string numeroDeIdentificacion, int edad, string posicion, double salario) : base ( nombre , apellidos, edad)
    {
        Id = id;
        Nombre = nombre;
        Apellidos = apellidos;
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Edad = edad;
        Posicion = posicion;
        Salario = salario;
    }

    private double CalcularBonificacion(double Salario)
    {
        double bonificacion = Salario +(Salario / 100* 10);
        
        return bonificacion;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($@"
        Id: {Id}
        Nombre: {Nombre}
        Apellidos: {Apellidos}
        Numero de identificación: {NumeroDeIdentificacion}
        Edad: {Edad}
        Posición: {Posicion}
        Salario: {CalcularBonificacion(Salario)}
        ");
    }
}