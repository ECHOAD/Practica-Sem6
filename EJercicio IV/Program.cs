/* Crear una aplicacion que genere un numero aleatorio entre 50 y 100. Y pida al usuario si desea 
 generar otro numero antes de terminar la aplicacion. El programa debe terminar cuando el usuario presione la letra 'S'*/
using System;

namespace EJercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            
            string exit;

            do
            {
                int a = rdn.Next(50, 100);
                Console.WriteLine("El numero aleatorio es: ");
                
                Console.Write(" "+a);
                
                Console.WriteLine();
                
                Console.WriteLine("Si quiere otro numero aletorio persione 'Enter' de lo contrario digite 's' ");

                
                exit = Console.ReadLine();
                exit = exit.ToLower();
            } while (exit != "s");
            
        }
    }
}
