//Crear una aplicacion que muestre la tabla de multiplicar del (7), tips usar ciclo while.
using System;

namespace Ejercicio_SEM_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, fac=7;

            Console.WriteLine("Programa de visualizacion de la tabla del 7.");

            while (i <= 12)
            {
                Console.WriteLine(fac + "X" + i + "="+(fac * i));
                i++;
            }
        }
    }
}
