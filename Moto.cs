using System;

namespace vehiculoHerencia
{
    
    public class Moto : Vehiculo
    {
        // Propiedades Moto
        public int Cilindrada { get; set; }
        public bool TieneMaletero { get; set; }

        
        public override void MostrarInformacion()
        {

            base.MostrarInformacion(); 
            Console.WriteLine($"Cilindrada: {Cilindrada} cc");
            Console.WriteLine($"¿Tiene Maletero?: {(TieneMaletero ? "Si" : "No")}");
        }
    }
}