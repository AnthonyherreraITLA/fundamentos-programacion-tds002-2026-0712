using System;

namespace CajaRegistradora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PORCENTAJE_ITBIS = 0.18; // 18% ITBIS
            double subtotal = 0;
            int cantidadProductos = 0;
            double precio;

            Console.WriteLine("=== CAJA REGISTRADORA ===");
            Console.WriteLine("Ingrese los precios de los productos (Escriba 0 para terminar):\n");

            // Ciclo do-while para lectura de precios
            do
            {
                Console.Write("Ingrese precio (DOP): ");
                if (double.TryParse(Console.ReadLine(), out precio) && precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
                else if (precio < 0)
                {
                    Console.WriteLine("El precio no puede ser negativo.");
                }
            } while (precio != 0);

            // Cálculos finales
            double itbis = subtotal * PORCENTAJE_ITBIS;
            double total = subtotal + itbis;

            // Salida de resultados con formato N2
            Console.WriteLine("\n==================================");
            Console.WriteLine("         RESUMEN DE VENTA         ");
            Console.WriteLine("==================================");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal:             RD$ {subtotal:N2}");
            Console.WriteLine($"ITBIS (18%):          RD$ {itbis:N2}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"TOTAL A PAGAR:        RD$ {total:N2}");
            Console.WriteLine("==================================");
        }
    }
}