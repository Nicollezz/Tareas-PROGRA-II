using System;

namespace vehiculoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //  2 objetos para carro
            Carro carro1 = new Carro
            {
                Marca = "Toyota",
                Modelo = "Corolla",
                Anio = 2020,
                NumeroPuertas = 4,
                TipoCombustible = "Gasolina"
            };

            Carro carro2 = new Carro
            {
                Marca = "Ford",
                Modelo = "F-150",
                Anio = 2022,
                NumeroPuertas = 4,
                TipoCombustible = "Gasolina"
            };

            //  2 objetos Moto 
            Moto moto1 = new Moto
            {
                Marca = "Honda",
                Modelo = "CB250",
                Anio = 2021,
                Cilindrada = 250,
                TieneMaletero = false
            };

            Moto moto2 = new Moto
            {
                Marca = "Yamaha",
                Modelo = "NMAX",
                Anio = 2023,
                Cilindrada = 155,
                TieneMaletero = true
            };

            // Hacer el llamado
            Console.WriteLine("*** INFORMACIÓN DE LOS CARROS ***");
            Console.WriteLine("===Carro 1===");
            carro1.MostrarInformacion();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("===Carro 2===");
            carro2.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("***INFORMACIÓN DE LAS MOTOS***");
            Console.WriteLine("===Moto 1===");
            moto1.MostrarInformacion();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("===Moto 2===");
            moto2.MostrarInformacion();

            
            Console.ReadLine();
        }
    }
}