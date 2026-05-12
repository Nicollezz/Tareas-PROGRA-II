namespace EjercicioClases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"¡Hola! Soy {Nombre} {Apellido} y tengo {Edad} años.");
        }
    }
}
