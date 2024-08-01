using Ssimu_GestionEmpleados.Models;

// crear un menu para interactuar con el programa

bool salir = false;

Empresa empresa = new Empresa("SSIMU", "Calle 1");

while (salir == false)
{   
    Console.Clear();
    Console.WriteLine("1. Agregar un nuevo empleado");
    Console.WriteLine("2. Eliminar un empleado");
    Console.WriteLine("3. Mostrar todos los empleados");
    Console.WriteLine("4. Actualizar un empleado");
    Console.WriteLine("5. Buscar un empleado");
    Console.WriteLine("6. Mostrar empleados por posición");
    Console.WriteLine("7. Agregar un nuevo cliente");
    Console.WriteLine("8. Eliminar un cliente");
    Console.WriteLine("9. Mostrar todos los clientes");
    Console.WriteLine("10. Salir");
    Console.Write("Elige una opción: ");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Clear();
            empresa.AgregarEmpleado();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 2:
            Console.Clear();
            empresa.EliminarEmpleado();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 3:
            Console.Clear();
            empresa.MostrarEmpleados();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 4:
            Console.Clear();
            empresa.ActualizarEmpleado();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 5:
            Console.Clear();
            empresa.BuscarEmpleado();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 6:
            Console.Clear();
            empresa.MostrarEmpleadosPorPosicion();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 7:
            Console.Clear();
            empresa.AgregarCliente();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 8:
            Console.Clear();
            empresa.EliminarCliente();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 9:
            Console.Clear();
            empresa.MostrarClientes();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 10:
            Console.WriteLine("Seguro que quieres salir? S/N");
            string? respuesta = Console.ReadLine();
            if (respuesta == "S" || respuesta == "s")
            {
                Console.WriteLine("Hasta pronto!");
                salir = true;
            }
            break;
        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
}