using System;

namespace _03_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lectura de dos números enteros
            Console.Write("Ingrese el primer número entero (n1): ");
            int n1 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el segundo número entero (n2): ");
            int n2 = int.Parse(Console.ReadLine() ?? "0");

            // Operaciones matemáticas
            int suma = n1 + n2;
            int resta = n1 - n2;
            int producto = n1 * n2;
            double divisionReal = (double)n1 / n2;
            int divisionEntera = n1 / n2;
            int residuo = n1 % n2;
            bool esPar = (n1 % 2 == 0);

            // Muestra de resultados
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Suma ({n1} + {n2}): {suma}");
            Console.WriteLine($"Resta ({n1} - {n2}): {resta}");
            Console.WriteLine($"Producto ({n1} * {n2}): {producto}");
            Console.WriteLine($"División real ({n1} / {n2}): {divisionReal}");
            Console.WriteLine($"División entera ({n1} / {n2}): {divisionEntera}");
            Console.WriteLine($"Residuo ({n1} % {n2}): {residuo}");
            Console.WriteLine($"¿El primer número ({n1}) es par?: {esPar}");
        }
    }
}

/*
 ===================================================
 PRUEBA DE ESCRITORIO (x = 10, y = 3)
 ===================================================
 Entrada: x = 10, y = 3

 Operación            | Expresión       | Resultado
 ---------------------|-----------------|-----------
 Suma                 | 10 + 3          | 13
 Resta                | 10 - 3          | 7
 Producto             | 10 * 3          | 30
 División real        | (double)10 / 3  | 3.3333333333333335
 División entera      | 10 / 3          | 3
 Residuo              | 10 % 3          | 1
 Es par el primero    | 10 % 2 == 0     | true
 ===================================================
*/