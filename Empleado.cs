using System;

namespace empleadoAbstraccion
{
    public abstract class Empleado
    {
        // Propiedades base
        public string? Nombre { get; set; }
        public int ID { get; set; }
        public double SalarioBase { get; set; }

        
        public abstract double CalcularSalarioAnual();
        public abstract void MostrarInformacion();
    }
}