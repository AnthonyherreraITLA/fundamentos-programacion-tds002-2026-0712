using System;

namespace Nomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constantes de descuentos de ley
            const double PORCENTAJE_AFP = 0.0287; // 2.87%
            const double PORCENTAJE_SFS = 0.0304; // 3.04%

            // 1. Entrada de datos
            Console.Write("Ingrese el nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine() ?? "";

            Console.Write("Ingrese las horas trabajadas: ");
            double horasTrabajadas = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el pago por hora (DOP): ");
            double pagoPorHora = double.Parse(Console.ReadLine() ?? "0");

            // 2. Proceso
            double salarioBruto = horasTrabajadas * pagoPorHora;
            double descuentoAFP = salarioBruto * PORCENTAJE_AFP;
            double descuentoSFS = salarioBruto * PORCENTAJE_SFS;
            double salarioNeto = salarioBruto - (descuentoAFP + descuentoSFS);

            // 3. Salida (Nombre en MAYÚSCULAS y montos con formato N2)
            Console.WriteLine("\n=== DETALLE DE NÓMINA ===");
            Console.WriteLine($"Empleado: {nombreEmpleado.ToUpper()}");
            Console.WriteLine($"Salario Bruto: RD$ {salarioBruto:N2}");
            Console.WriteLine($"Descuento AFP (2.87%): RD$ {descuentoAFP:N2}");
            Console.WriteLine($"Descuento SFS (3.04%): RD$ {descuentoSFS:N2}");
            Console.WriteLine($"Salario Neto: RD$ {salarioNeto:N2}");
        }
    }
}