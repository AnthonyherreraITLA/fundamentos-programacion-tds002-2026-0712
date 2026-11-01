using System;

namespace _06_Decisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("    PARTE 1: EVALUACIÓN DE CALIFICACIÓN   ");
            Console.WriteLine("==========================================");

            Console.Write("Ingrese la nota (0-100): ");
            string entradaNota = Console.ReadLine() ?? "";

            // Validación de entrada numérica
            if (int.TryParse(entradaNota, out int nota) && nota >= 0 && nota <= 100)
            {
                char letra;

                // Estructura de decisión if - else if - else
                if (nota >= 90)
                {
                    letra = 'A';
                }
                else if (nota >= 80)
                {
                    letra = 'B';
                }
                else if (nota >= 70)
                {
                    letra = 'C';
                }
                else
                {
                    letra = 'F';
                }

                Console.WriteLine($"Resultado: Nota = {nota} -> Calificación literal = {letra}");
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar una nota válida entre 0 y 100.");
            }

            Console.WriteLine("\n==========================================");
            Console.WriteLine("          PARTE 2: CALCULADORA            ");
            Console.WriteLine("==========================================");

            Console.Write("Ingrese el primer número: ");
            double n1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el segundo número: ");
            double n2 = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("\nMenú de Opciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Seleccione una opción (1-4): ");
            int opcion = int.Parse(Console.ReadLine() ?? "0");

            // Estructura de selección switch
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {n1} + {n2} = {n1 + n2}");
                    break;

                case 2:
                    Console.WriteLine($"Resultado de la resta: {n1} - {n2} = {n1 - n2}");
                    break;

                case 3:
                    Console.WriteLine($"Resultado del producto: {n1} * {n2} = {n1 * n2}");
                    break;

                case 4:
                    if (n2 != 0)
                    {
                        Console.WriteLine($"Resultado de la división: {n1} / {n2} = {n1 / n2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No es posible dividir entre cero.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida. Debe seleccionar un número del 1 al 4.");
                    break;
            }
        }
    }
}