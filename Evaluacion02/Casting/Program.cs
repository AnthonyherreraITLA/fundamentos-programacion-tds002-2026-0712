using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar número decimal
            Console.Write("Ingrese un número con decimales (ej. 15.87): ");
            double numeroDecimal = double.Parse(Console.ReadLine() ?? "0");

            // Casting explícito de double a int
            int parteEntera = (int)numeroDecimal;

            // Casting implícito de int a double
            int numeroEntero = 42;
            double enteroConvertidoADouble = numeroEntero;

            // Salida con interpolación
            Console.WriteLine("\n--- DEMOSTRACIÓN DE CASTING ---");
            Console.WriteLine($"Número decimal original (double): {numeroDecimal}");
            Console.WriteLine($"Parte entera mediante casting explícito (int): {parteEntera}");
            Console.WriteLine($"Entero original (int): {numeroEntero}");
            Console.WriteLine($"Valor promovido mediante casting implícito (double): {enteroConvertidoADouble}");
        }
    }
}