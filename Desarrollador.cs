using System;

namespace empleadoAbstraccion
{
    public class Desarrollador : Empleado
    {
        
        public string? LenguajePrincipal { get; set; }

        // Uso de formula
        public override double CalcularSalarioAnual()
        {
            return SalarioBase * 12;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"DESARROLLADOR (ID: {ID})");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base Mensual: ${SalarioBase}");
            Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
            Console.WriteLine($"Salario Anual Total: ${CalcularSalarioAnual()}");
        }
    }
}