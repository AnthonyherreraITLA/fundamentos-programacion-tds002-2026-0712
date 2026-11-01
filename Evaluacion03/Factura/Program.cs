using System;

namespace Factura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constante de ITBIS
            const double PORCENTAJE_ITBIS = 0.18; // 18%

            // 1. Entrada de datos
            Console.Write("Ingrese la descripción del producto: ");
            string producto = Console.ReadLine() ?? "";

            Console.Write("Ingrese la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el precio unitario (DOP): ");
            double precio = double.Parse(Console.ReadLine() ?? "0");

            // 2. Proceso
            double subtotal = cantidad * precio;
            double itbis = subtotal * PORCENTAJE_ITBIS;
            double total = subtotal + itbis;

            // 3. Salida alineada en columnas
            Console.WriteLine("\n============================================");
            Console.WriteLine("               FACTURA DE VENTA             ");
            Console.WriteLine("============================================");
            Console.WriteLine($"{"Producto:":-20} {producto.PadRight(20)}");
            Console.WriteLine($"{"Cantidad:":-20} {cantidad,20}");
            Console.WriteLine($"{"Precio Unitario:":-20} {precio,20:N2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{"Subtotal:":-20} {subtotal,20:N2}");
            Console.WriteLine($"{"ITBIS (18%):":-20} {itbis,20:N2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{"TOTAL A PAGAR:":-20} {total,20:N2}");
            Console.WriteLine("============================================");
        }
    }
}