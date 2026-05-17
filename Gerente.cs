using System;

namespace empleadoAbstraccion
{
    public class Gerente : Empleado
    {
        
        public double BonoAnual { get; set; }

        // Hacer uso de la formula
        public override double CalcularSalarioAnual()
        {
            return (SalarioBase * 12) + BonoAnual;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"GERENTE (ID: {ID})");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base Mensual: ${SalarioBase}");
            Console.WriteLine($"Bono Anual: ${BonoAnual}");
            Console.WriteLine($"Salario Anual Total: ${CalcularSalarioAnual()}");
        }
    }
}