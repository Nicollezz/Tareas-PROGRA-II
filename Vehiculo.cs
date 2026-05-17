using System;

namespace vehiculoHerencia
{
    public class Vehiculo
    {
        // Propiedades vehiculo
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
        }
    }
}