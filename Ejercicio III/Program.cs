/*Crear un programa que me diga la cantidad de digitos que tiene un numero positivo. Mostrar en mensaje ej: El numero ingresado tiene (N) digitos.*/
using System;

namespace Ejercicio_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int cd, num;

            Console.WriteLine("Programa para determinar la cantidad de digitos que tiee un numero ");
            Console.Write("Ingrese el numero: ");
            num = int.Parse(Console.ReadLine());
            cd = (Convert.ToString(num)).Length;

            Console.WriteLine("La cantidad de digitos que tiene {0} es : {1}",num,cd);

            Console.WriteLine();

            Console.WriteLine("El programa ha finalizado");
        }
    }
}
