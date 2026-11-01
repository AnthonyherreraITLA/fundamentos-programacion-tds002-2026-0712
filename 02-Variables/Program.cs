using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constante requerida
            const int ANIO_ACTUAL = 2026;

            // Solicitar datos por consola
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su estatura en metros (ej. 1.85): ");
            double estatura = double.Parse(Console.ReadLine());

            // Cálculo del año de nacimiento
            int anioNacimiento = ANIO_ACTUAL - edad;

            // Salida con interpolación $"..."
            Console.WriteLine();
            Console.WriteLine($"--- DATOS REGISTRADOS ---");
            Console.WriteLine($"Hola, {nombre}. Tienes {edad} años y tu estatura es de {estatura} m.");
            Console.WriteLine($"Naciste en el año {anioNacimiento} (calculado en base al año {ANIO_ACTUAL}).");
        }
    }
}
