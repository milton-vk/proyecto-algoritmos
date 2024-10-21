/*
 * Creado por SharpDevelop.
 * Usuario: mauri
 * Fecha: 21/10/2024
 * Hora: 19:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyecto_final
{
	class Program
	{
		public static void Main(string[] args)
		{
			class Program
{
    static void Main(string[] args)
    {
        List<Entrenador> entrenadores = new List<Entrenador>();
        List<Deporte> deportes = new List<Deporte>();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("a- Dar de alta a un entrenador");
            Console.WriteLine("b- Dar de baja a un entrenador");
            Console.WriteLine("c- Dar de alta a un niño/socio en un deporte");
            Console.WriteLine("d- Dar de baja a un niño/socio en un deporte");
            Console.WriteLine("e- Simular el pago de una cuota");
            Console.WriteLine("f- Submenú de inscripción");
            Console.WriteLine("g- Listado de deudores");
            Console.WriteLine("h- Agregar un deporte");
            Console.WriteLine("i- Eliminar un deporte");
            Console.WriteLine("j- Salir");
            
            string opción = Console.ReadLine();

            switch (opción)
            {
                case "a":
                    // Lógica para dar de alta a un entrenador
                    break;
                case "b":
                    // Lógica para dar de baja a un entrenador
                    break;
                case "c":
                    // Lógica para dar de alta a un niño/socio
                    break;
                case "d":
                    // Lógica para dar de baja a un niño/socio
                    break;
                case "e":
                    // Lógica para simular el pago de una cuota
                    break;
                case "f":
                    // Submenú de inscripción
                    break;
                case "g":
                    // Listado de deudores
                    break;
                case "h":
                    // Lógica para agregar un deporte
                    break;
                case "i":
                    // Lógica para eliminar un deporte
                    break;
                case "j":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}

			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
