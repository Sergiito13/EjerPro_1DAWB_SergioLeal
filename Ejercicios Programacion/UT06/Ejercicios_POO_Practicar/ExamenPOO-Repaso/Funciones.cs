using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examentienda
{
    internal class Funciones
    {
        
        public static void MostrarMenu()
        {
            Console.WriteLine("Eliga una de las siguientes opciones");
            Console.WriteLine("1.- Alquilar juego");
            Console.WriteLine("2.- Devolver juego");
            Console.WriteLine("3.- Mostrar info tienda");
            Console.WriteLine("4.- Mostrar historial");
            Console.WriteLine("0.- Salir");
        }

        public static int PedirOpcionesMenu()
        {
            int opcion = 0;
            Console.WriteLine("");
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Error! Tiene que ser un número");
            }
            return opcion;
        }
    }
}
