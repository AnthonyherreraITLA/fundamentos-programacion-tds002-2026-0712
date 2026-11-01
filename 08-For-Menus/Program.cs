using System;

namespace _08_For_Menus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("       MENÚ PRINCIPAL - SEMANA 8          ");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Mostrar tablas del 1 al 10 (Ciclos Anidados)");
                Console.WriteLine("2. Dibujar triángulo de asteriscos");
                Console.WriteLine("0. Salir");
                Console.WriteLine("==========================================");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        MostrarTablasMultiplicar();
                        break;

                    case 2:
                        DibujarTriangulo();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa... ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        // 1. Tablas del 1 al 10 con ciclos anidados for y formato {valor,4}
        static void MostrarTablasMultiplicar()
        {
            Console.WriteLine("=== TABLAS DE MULTIPLICAR DEL 1 AL 10 ===\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"--- TABLA DEL {i} ---");
                for (int j = 1; j <= 10; j++)
                {
                    int producto = i * j;
                    Console.WriteLine($"{i,2} x {j,2} = {producto,4}");
                }
                Console.WriteLine();
            }
        }

        // 2. Triángulo de asteriscos de N filas
        static void DibujarTriangulo()
        {
            Console.WriteLine("=== DIBUJAR TRIÁNGULO DE ASTERISCOS ===");
            Console.Write("Ingrese la cantidad de filas (N): ");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.WriteLine();
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número entero mayor a 0.");
            }
        }
    }
}