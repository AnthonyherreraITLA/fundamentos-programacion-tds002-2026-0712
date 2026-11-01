using System;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULOS GEOMÉTRICOS ===");

            // 1. Entrada de datos
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el cateto A del triángulo rectángulo: ");
            double catetoA = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el cateto B del triángulo rectángulo: ");
            double catetoB = double.Parse(Console.ReadLine() ?? "0");

            // 2. Proceso usando Math.PI, Math.Pow y Math.Sqrt
            double areaCirculo = Math.PI * Math.Pow(radio, 2);
            double circunferencia = 2 * Math.PI * radio;
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            // 3. Salida de resultados con 2 decimales
            Console.WriteLine("\n--- RESULTADOS CÍRCULO ---");
            Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
            Console.WriteLine($"Circunferencia: {circunferencia:F2}");

            Console.WriteLine("\n--- RESULTADOS TRIÁNGULO RECTÁNGULO ---");
            Console.WriteLine($"Cateto A: {catetoA:F2}");
            Console.WriteLine($"Cateto B: {catetoB:F2}");
            Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
        }
    }
}