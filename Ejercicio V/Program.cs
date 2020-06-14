// Crear una aplicacion que muestre la cantidad de 0 que hay del 1 al 100
using System;

namespace Ejercicio_V
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cc=3;
            for (int i = 1; i < 100; i++)
            {
               
                if (i % 10 == 0)
                {
                    cc=cc+1;
                }
            }
            Console.WriteLine($"La cantidad de ceros son: {cc}");
        }
    }
}
