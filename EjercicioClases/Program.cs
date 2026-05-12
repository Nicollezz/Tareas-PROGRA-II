using System;

namespace EjercicioClases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Libros
            Libro libro1 = new Libro { Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", AñoPublicacion = 1943 };
            Libro libro2 = new Libro { Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez", AñoPublicacion = 1967 };
            Libro libro3 = new Libro { Titulo = "1984", Autor = "George Orwell", AñoPublicacion = 1949 };

            // Personas
            Persona persona1 = new Persona { Nombre = "Sofía", Apellido = "García", Edad = 25 };
            Persona persona2 = new Persona { Nombre = "Luis", Apellido = "Martínez", Edad = 30 };

            // Estante
            Estante estante1 = new Estante { NumeroEstante = 1, CapacidadMaxima = 5 };
            estante1.LibrosEnEstante.Add(libro1);
            estante1.LibrosEnEstante.Add(libro2);
            estante1.LibrosEnEstante.Add(libro3);

            // Mostrar información
            Console.WriteLine("=== LIBROS ===");
            libro1.MostrarInformacion();
            libro2.MostrarInformacion();
            libro3.MostrarInformacion();

            Console.WriteLine("\n=== PERSONA ===");
            persona1.Saludar();
            persona2.Saludar();

            Console.WriteLine("\n=== ESTANTE ===");
            estante1.MostrarContenido();

            Console.WriteLine("\nSALIR CON ENTER...");
            Console.ReadKey();
        }
    }
}
