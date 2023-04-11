using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class Menu
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine(" =================menu==================");
            Console.WriteLine(" |-------------------------------------|");
            Console.WriteLine(" | 1.- Crear cliente                   |");
            Console.WriteLine(" | 2.- Buscar cliente                  |");
            Console.WriteLine(" | 3.- Mostrar cliente                 |");
            Console.WriteLine(" | 4.- Eliminar cliente                |");
            Console.WriteLine(" | 5.- Salir                           |");
            Console.WriteLine(" |-------------------------------------|");
            Console.WriteLine(" =======================================");
        }

        public static int PedirOpcionMenu()
        {
            // Declaramos las variables
            int opcionMenu = 0;

            Console.WriteLine("");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine(" Dime una opcion para el menu");
            while (!int.TryParse(Console.ReadLine(), out opcionMenu) || (opcionMenu < 1) || opcionMenu > 5 )
            {
                Console.WriteLine("Error la opcion elegida no es correcta");
            }
            return opcionMenu;
        }

        public static bool OpcionesMenu()
        {
            // Declaramos las variables
            bool salir = false;
            List<Clientes> cliente = new List<Clientes>();

            do
            {
                MostrarMenu();
                int opcionMenu = PedirOpcionMenu();

                Console.WriteLine("");
                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Haz elegido la opción 1. ");
                        Funciones.AñadirNuevoCliente();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Haz elegido la opción 2. ");
                        Clientes.BuscarSiNombreExiste(cliente);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Haz elegido la opción 3. ");
                        Clientes.MostrarClientesLista(cliente);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Haz elegido la opción 4. ");
                        Clientes.EliminarClienteLista(cliente);
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        salir = true;
                        break;
                }
            } while (!salir);


            return salir;
        }
    }
}
