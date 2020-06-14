//2.: Crear una aplicacion que le pida al usuario un numero positivo y el sistema identifique si es primo o no.
using System;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, nd = 0 ,i,exit=0;
            Console.WriteLine("Programa para verificar si el numero es primo o no");

            Console.Write("Ingrese un numero: ");

            num = int.Parse(Console.ReadLine());

            while (num < 0)
            {
                Console.WriteLine("Error, el numero tiene que ser positivo");
                Console.WriteLine();
                
                Console.Write("Ingrese un numero");

                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    exit++;
                }
                if (exit >= 2)
                {
                    Console.WriteLine("Agoto los intentos del programa");
                    break;
                }


            }

            if (exit < 2)
            {
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        nd ++;
                    }
                }
                 if (nd > 2)
                     {
                        Console.WriteLine("El numero {0} no es primo", num);

                     }
                 else
                    {
                        Console.WriteLine("El numero {0}  es primo", num);
                    }
                

            }

            Console.WriteLine("El programa ha finalizado");


           

        }
    }
}
