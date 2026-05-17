using System;

namespace vehiculoHerencia
{
    
    public class Carro : Vehiculo
    {
        // Propiedades Carro
        public int NumeroPuertas { get; set; }
        public string TipoCombustible { get; set; }

        
        public override void MostrarInformacion()
        {
            base.MostrarInformacion(); 
            Console.WriteLine($"Número de Puertas: {NumeroPuertas}");
            Console.WriteLine($"Tipo de Combustible: {TipoCombustible}");
        }
    }
}