using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCopisteria
{
    class Menu
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("|                    MENU                       |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("| 0. Salir del programa                         |");
            Console.WriteLine("| 1. Realizar Venta                             |");
            Console.WriteLine("| 2. Mostrar datos de venta                     |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("------------------------------------------------");
        }

        public static void OpcionesMenu(PersonasInscritas[] personas, VentasRealizadas[] ventas)
        {
            // Declaramos las variables
            bool Salir = false;
            int NumeroOpcion = 0;

            int[] BonosClientes = CSTienda.SacarBonosPersonas(personas);

            do
            {

                MostrarMenu();
                Console.WriteLine("\n¿Que opcion quiere?");
                while (!int.TryParse(Console.ReadLine(), out NumeroOpcion))
                {
                    Console.WriteLine("ERROR ! Tiene que ser de tipo entero");
                }
                if ((NumeroOpcion >= 0) && (NumeroOpcion <= 2))
                {
                    switch (NumeroOpcion)
                    {
                        case 0:
                            {
                                Salir = true;
                                Console.WriteLine("Ha decididio cerrar el programa. ADIOS");

                            }
                            break;

                        case 1:
                            {
                                ventas = CSTienda.RealizarNuevaVenta(ventas, personas, BonosClientes);
                            }
                            break;

                        case 2:
                            {
                                CSTienda.MostrarVentas(ventas, personas, BonosClientes);               
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error ! Este número no es una opcion del menu");
                }

            } while (!Salir);


        }
    }
}