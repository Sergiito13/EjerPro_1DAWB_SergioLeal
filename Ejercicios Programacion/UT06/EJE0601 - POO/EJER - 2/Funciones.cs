using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Funciones
    {
        public static int SacarIDProducto(List<Productos> products)
        {
            // Declaramos las variables
            int IDCliente = 0;

            foreach (Productos prod in products)
            {
                IDCliente = prod.GetID();
            }

            return IDCliente;
        }

        public static string PedirNombreProducto()
        {
            // Declaramos las variables
            string nombreProducto = "";
            bool salir = false;

            do
            {
                Console.WriteLine("Dime el nombre del producto");
                nombreProducto = Console.ReadLine();

                if (nombreProducto.Length > 0)
                {
                    nombreProducto = nombreProducto.Trim();
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! El nombre no es valido");
                }
            } while (!salir);

            return nombreProducto;
        }

        public static decimal PedirPrecioProducto()
        {
            // Declaramos las variables
            decimal precioProducto = 0;
            bool salir = false;

            do
            {

                Console.WriteLine("Dime el precio del producto");
                while ((!decimal.TryParse(Console.ReadLine(), out precioProducto) || (precioProducto < 0)))
                {
                    Console.WriteLine("Error el precio no es valido");
                }
                salir = true;
            } while (!salir);
            return precioProducto;
        }
        public static void MostrarProductos(List<Productos> products)
        {
            Console.Clear();
            Console.WriteLine("| LISTA DE PRODUCTOS: ");
            Console.WriteLine("---------------------------");

            foreach (Productos pro in products)
            {
                Console.WriteLine(pro.ToString());


            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
        }

        public static decimal PedirDineroUsuario(decimal dineroacumulado)
        {
            // Declaramos las variables
            decimal dineroUsuario = 0;

            Console.WriteLine("Introduzca el dinero");
            while (!decimal.TryParse(Console.ReadLine(), out dineroUsuario) || (dineroUsuario <= 0))
            {
                Console.WriteLine(" ERROR ! El dinero no es valido");
            }
            dineroUsuario += dineroacumulado;
            return dineroUsuario;
        }

    }
}
