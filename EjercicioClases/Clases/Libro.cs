namespace EjercicioClases
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Año: {AñoPublicacion}");
        }
    }
}
