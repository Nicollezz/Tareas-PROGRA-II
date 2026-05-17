using System;

namespace empleadoAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciar Gerente con datos pre-cargados
            Gerente gerente = new Gerente
            {
                ID = 001,
                Nombre = "Andrea Guevara",
                SalarioBase = 25000.00,
                BonoAnual = 5000.00
            };

            
            Desarrollador desarrollador = new Desarrollador
            {
                ID = 002,
                Nombre = "Emerson Orellana",
                SalarioBase = 30000.00,
                LenguajePrincipal = "C#"
            };

            
            Contador contador = new Contador
            {
                ID = 003,
                Nombre = "Ana Mejía",
                SalarioBase = 28000.00,
                HorasExtras = 15,
                PagoPorHoraExtra = 20.0
            };

            
            
            Console.WriteLine("*** SISTEMA DE GESTIÓN DE EMPLEADOS ***");
            

            gerente.MostrarInformacion();
            Console.WriteLine("\n--------------------------------------------------\n");

            desarrollador.MostrarInformacion();
            Console.WriteLine("\n--------------------------------------------------\n");

            contador.MostrarInformacion();
            Console.WriteLine("\n==================================================");

            
            Console.ReadLine();
        }
    }
}