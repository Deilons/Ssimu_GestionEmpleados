using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ssimu_GestionEmpleados.Models;

public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public byte Edad { get; set; }
    public string Posicion { get; set; }
    public double Salario { get; set; }

    public Empleado(int id, string nombre, string apellidos, string numeroDeIdentificacion, byte edad, string posicion, double salario)
    {
        Id = id;
        Nombre = nombre;
        Apellidos = apellidos;
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Edad = edad;
        Posicion = posicion;
        Salario = salario;
    }

    private static double CalcularBonificacion(double Salario)
    {
        double bonificacion = Salario / 100* 10;
        
        return bonificacion;
    }

    public void MostrarInformacion()
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