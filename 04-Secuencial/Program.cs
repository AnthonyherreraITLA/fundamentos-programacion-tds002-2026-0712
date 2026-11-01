using System;

namespace _04_Secuencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constante requerida por la consigna
            const double KG_POR_LIBRA = 0.453592;

            Console.WriteLine("=== CONVERSOR DE UNIDADES ===");

            // 1. Entrada de datos
            Console.Write("Ingrese el peso en libras (lb): ");
            double libras = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese la temperatura en Fahrenheit (°F): ");
            double fahrenheit = double.Parse(Console.ReadLine() ?? "0");

            // 2. Procesamiento
            double kilogramos = libras * KG_POR_LIBRA;
            double celsius = (fahrenheit - 32) * 5 / 9;

            // 3. Salida de resultados formateados a 2 decimales
            Console.WriteLine("\n=== RESULTADOS DE CONVERSIÓN ===");
            Console.WriteLine($"Peso: {libras:F2} lb equivale a {kilogramos:F2} kg");
            Console.WriteLine($"Temperatura: {fahrenheit:F2} °F equivale a {celsius:F2} °C");
        }
    }
}