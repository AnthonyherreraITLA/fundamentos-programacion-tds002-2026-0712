using System;

namespace _07_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool esValido = false;

            Console.WriteLine("==========================================");
            Console.WriteLine("    TABLA DE MULTIPLICAR CON CICLOS       ");
            Console.WriteLine("==========================================");

            // 1. Validación con ciclo do-while
            do
            {
                Console.Write("Ingrese un número entero entre 1 y 12: ");
                string entrada = Console.ReadLine() ?? "";

                if (int.TryParse(entrada, out numero) && numero >= 1 && numero <= 12)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, intente de nuevo.\n");
                }
            } while (!esValido);

            Console.WriteLine($"\n--- TABLA DE MULTIPLICAR DEL {numero} ---");

            // Variables para la tabla y el acumulador
            int contador = 1;
            int sumaResultados = 0;

            // 2. Generar tabla de multiplicar con ciclo while
            while (contador <= 12)
            {
                int resultado = numero * contador;
                sumaResultados += resultado; // Acumulador

                Console.WriteLine($"{numero} x {contador,2} = {resultado,3}");
                contador++;
            }

            // 3. Muestra de la suma de todos los resultados
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Suma total de los resultados: {sumaResultados}");
            Console.WriteLine("==========================================");
        }
    }
}