using System.Collections.Generic;

namespace EjercicioClases
{
    public class Estante
    {
        public int NumeroEstante { get; set; }
        public int CapacidadMaxima { get; set; }
        public List<Libro> LibrosEnEstante { get; set; } = new List<Libro>();

        public void MostrarContenido()
        {
            Console.WriteLine($"\nEstante {NumeroEstante} (Capacidad: {CapacidadMaxima})");
            foreach (var libro in LibrosEnEstante)
            {
                libro.MostrarInformacion();
            }
        }
    }
}
