using System;

namespace PromedioValidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumaNotas = 0;
            int contadorNotas = 0;
            double notaMayor = double.MinValue;
            double notaMenor = double.MaxValue;
            double nota = 0;

            Console.WriteLine("=== PROMEDIO DE NOTAS VALIDADO ===");
            Console.WriteLine("Ingrese notas válidas (0 a 100). Escriba -1 para finalizar y calcular:\n");

            while (true)
            {
                bool notaValida = false;

                // Validación con do-while y TryParse
                do
                {
                    Console.Write("Ingrese una nota (o -1 para salir): ");
                    string entrada = Console.ReadLine() ?? "";

                    if (double.TryParse(entrada, out nota))
                    {
                        if ((nota >= 0 && nota <= 100) || nota == -1)
                        {
                            notaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("La nota debe estar entre 0 y 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Ingrese un número.");
                    }
                } while (!notaValida);

                if (nota == -1)
                {
                    break; // Finaliza la captura
                }

                // Acumulación y comparación de mayor y menor
                sumaNotas += nota;
                contadorNotas++;

                if (nota > notaMayor) notaMayor = nota;
                if (nota < notaMenor) notaMenor = nota;
            }

            Console.WriteLine("\n==================================");
            Console.WriteLine("      ESTADÍSTICAS DE NOTAS       ");
            Console.WriteLine("==================================");

            if (contadorNotas > 0)
            {
                double promedio = sumaNotas / contadorNotas;
                Console.WriteLine($"Cantidad de notas ingresadas: {contadorNotas}");
                Console.WriteLine($"Promedio de notas:            {promedio:F2}");
                Console.WriteLine($"Nota más ALTA:                {notaMayor:F2}");
                Console.WriteLine($"Nota más BAJA:                {notaMenor:F2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron notas para evaluar.");
            }
            Console.WriteLine("==================================");
        }
    }
}