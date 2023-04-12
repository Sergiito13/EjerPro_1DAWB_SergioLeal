using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Funciones
    {
        public static int SacarIDProducto()
        {
            // Declaramos las variables
            List<Productos> produc = new List<Productos>();
            int IDCliente = 0;

            foreach (Productos prod in produc)
            {
                IDCliente = prod.GetID();
            }
            IDCliente++;

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

        public static void AñadirProducto()
        {
            // Declaramos las variables
            List<Productos> produc = new List<Productos>();
            bool salir = false, salirPregunta = false;
            const int NUMERO_MAXIMO_PRODUCTO = 20, STOCK_PRODUCTOS = 10;
            int IDProducto = 0, contador = 0;
            string nombreProducto = "", preguntaSeguir = "";
            decimal precioProducto = 0;

            do
            {
                IDProducto = SacarIDProducto();
                contador = IDProducto;

                nombreProducto = PedirNombreProducto();
                precioProducto = PedirPrecioProducto();

                Productos productoAux = new Productos(IDProducto, nombreProducto, precioProducto, STOCK_PRODUCTOS);
                produc.Add(productoAux);
                Console.WriteLine("Se ha añadido correctamente el producto");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");

                salirPregunta = false;
                do
                {
                    Console.WriteLine("¿Quieres añadir otro producto? [si | no]");
                    preguntaSeguir = Console.ReadLine();

                    if (preguntaSeguir.Length > 0)
                    {
                        if ((preguntaSeguir == "si")||(preguntaSeguir == "Si") || (preguntaSeguir == "SI") || (preguntaSeguir == "sI"))
                        {
                            salirPregunta = true;
                        }
                        else if ((preguntaSeguir == "no") || (preguntaSeguir == "No") || (preguntaSeguir == "NO") || (preguntaSeguir == "nO"))
                        {
                            Console.WriteLine("Ha decidido no añadir más producto");
                            salirPregunta = true;
                            salir = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! La respuesta no puede estar vacia");
                    }

                } while (!salirPregunta);

            } while (!salir && contador <= NUMERO_MAXIMO_PRODUCTO);






            
        }
    }
}
