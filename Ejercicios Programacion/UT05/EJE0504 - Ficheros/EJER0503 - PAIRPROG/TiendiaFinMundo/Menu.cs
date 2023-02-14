using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienditaPOSTAPOCALIPTICA
{
    class Menu
    {
        public static void MostrarMenuOpciones() // ESTA FUNCION MOSTRARA LAS OPCIONES QUE TENEMOS EN EL MENU
        {
            // Declaramos las variables
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("|                 -MENU-                  |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|                                         |");
            Console.WriteLine("| 1. Nuevo pedido                         |");
            Console.WriteLine("| 2. Ver ventas totales por producto      |");
            Console.WriteLine("| 3. Ver compras por usuarios             |");
            Console.WriteLine("| 4. Solicitar saldo de cliente           |");
            Console.WriteLine("| 5. Salir del programa                   |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("-------------------------------------------");
        }

        public static void MenuOpciones() // ESTA FUNCION SERA EL MENU DONDE ESTEN LAS OPCIONES
        {
            // Declaramos las variables
            bool Salir = false;
            int OpcionMenu = 0;

            do
            {
                MostrarMenuOpciones(); // Llamamos a la funcion que muestra el menu
                Console.WriteLine("\nDime la opcion que quieras");

                while (!int.TryParse(Console.ReadLine(), out OpcionMenu))
                {
                    Console.WriteLine("Error ! El tipo de dato tiene que ser entero");
                }

                if ((OpcionMenu >= 1) && (OpcionMenu <= 5))
                {
                    switch (OpcionMenu)
                    {
                        case 1:
                            {
                                Funciones.
                            }
                            break;
                        case 2:
                            {

                            }
                            break;
                        case 3:
                            {

                            }
                            break;
                        case 4:
                            {

                            }
                            break;
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Haz elegido la opcion de salir. ADIOS");
                                Salir = true;
                            }break;

                    }
                }
                else
                {
                    Console.WriteLine("Error ! La opcion introducida no es valida. Intentelo de nuevo");
                    Console.WriteLine("Pulsa para continuar.");
                    Console.ReadKey();
                }
            } while (!Salir);
        }
    }
}
