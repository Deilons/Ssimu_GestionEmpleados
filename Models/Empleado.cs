using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models;

public class Empleado : Persona
{
    
    public string Posicion { get; set; }
    public decimal Salario { get; set; }

    public Empleado(Guid id, string nombre, string apellidos, string numeroDeIdentificacion, int edad, string posicion, decimal salario) : base (id,nombre , apellidos, edad, numeroDeIdentificacion)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Edad = edad;
        Posicion = posicion;
        Salario = salario;
    }

    private decimal CalcularBonificacion(decimal Salario)
    {
        decimal bonificacion = Salario +(Salario / 100* 10);
        
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