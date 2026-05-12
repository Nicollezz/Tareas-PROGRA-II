using System;

namespace EjercicioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            double suma = 0;

            Console.WriteLine("-- PROMEDIO DE NOTAS --");

            for (int i = 0; i < notas.Length; i++)
            {
                bool notaValida = false;

                while (!notaValida)
                {
                    try
                    {
                        Console.Write($"Ingresa la nota {i + 1}: ");
                        double nota = double.Parse(Console.ReadLine() ?? "0");

                        if (nota < 0 || nota > 100)
                        {
                            throw new Exception("La nota debe estar entre 0 y 100.");
                        }

                        notas[i] = nota;
                        suma += nota;
                        notaValida = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(" ERROR: Ingresa un número válido.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($" {ex.Message}");
                    }
                }
            }

            try
            {
                if (notas.Length == 0)
                {
                    throw new DivideByZeroException("No se ingresaron notas, el promedio no se puede calcular.");
                }

                double promedio = suma / notas.Length;
                Console.WriteLine($"\n El promedio de las {notas.Length} notas es: {promedio:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error inesperado: {ex.Message}");
            }

            Console.WriteLine("\nPresiona enter :)");
            Console.ReadKey();
        }
    }
}
