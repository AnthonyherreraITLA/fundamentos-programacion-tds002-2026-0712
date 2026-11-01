using System;

namespace AdivinaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generación de número secreto entre 1 y 100
            int numeroSecreto = Random.Shared.Next(1, 101);
            int intentoUsuario = 0;
            int contadorIntentos = 0;

            Console.WriteLine("=== JUEGO: ADIVINA EL NÚMERO ===");
            Console.WriteLine("He pensado un número entre 1 y 100. ¡Intenta adivinarlo!\n");

            // Ciclo while para adivinar el número
            while (intentoUsuario != numeroSecreto)
            {
                Console.Write("Introduce tu intento: ");
                if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                {
                    contadorIntentos++;

                    if (intentoUsuario < numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es MAYOR.\n");
                    }
                    else if (intentoUsuario > numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es MENOR.\n");
                    }
                    else
                    {
                        Console.WriteLine($"\n¡Felicidades! Adivinaste el número secreto ({numeroSecreto}).");
                        Console.WriteLine($"Total de intentos realizados: {contadorIntentos}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.\n");
                }
            }
        }
    }
}