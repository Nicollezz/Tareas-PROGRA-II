using System;

namespace empleadoAbstraccion
{
    public class Contador : Empleado
    {
        
        public int HorasExtras { get; set; }
        public double PagoPorHoraExtra { get; set; }

        // uso de formula
        public override double CalcularSalarioAnual()
        {
            return (SalarioBase * 12) + (HorasExtras * PagoPorHoraExtra);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"CONTADOR (ID: {ID})");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base Mensual: ${SalarioBase}");
            Console.WriteLine($"Horas Extras Trabajadas: {HorasExtras}");
            Console.WriteLine($"Pago por Hora Extra: ${PagoPorHoraExtra}");
            Console.WriteLine($"Salario Anual Total: ${CalcularSalarioAnual()}");
        }
    }
}