using System;

namespace FichaPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int anioActual = 2026;

            // Solicitar datos personales
            Console.Write("Ingrese su nombre: ");
            string nombrePersona = Console.ReadLine() ?? "";

            Console.Write("Ingrese su edad: ");
            int edadPersona = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese su estatura en metros (ej. 1.85): ");
            double estaturaPersona = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("¿Trabaja actualmente? (true/false): ");
            bool trabajaPersona = bool.Parse(Console.ReadLine() ?? "false");

            // Cálculo del año en que cumplirá 30 años
            int anioCumpleTreinta = (anioActual - edadPersona) + 30;

            // Ficha con interpolación
            Console.WriteLine("\n--- FICHA PERSONAL ---");
            Console.WriteLine($"Nombre: {nombrePersona}");
            Console.WriteLine($"Edad: {edadPersona} años");
            Console.WriteLine($"Estatura: {estaturaPersona} m");
            Console.WriteLine($"¿Trabaja?: {trabajaPersona}");
            Console.WriteLine($"Año en que cumplirá 30 años: {anioCumpleTreinta}");
        }
    }
}