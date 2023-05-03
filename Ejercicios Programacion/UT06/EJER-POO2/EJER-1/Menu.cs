namespace ejer2
{
    class Menu
    {

        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------Menu Principal-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1.- Opciones producto                 -");
            Console.WriteLine("- 2.- Opciones Linea Máquina            -");
            Console.WriteLine("- 3.- Comprar producto Linea Máquina    -");
            Console.WriteLine("- 4.- Salir del programa                -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
        }

        public static int PedirNumeroOpcionMenu()
        {
            // Declaramos las variables
            int numeroUser = 0;
            bool salir = false;

            do
            {
                Console.WriteLine("Dime una opción para el menu");
                while ((!int.TryParse(Console.ReadLine(), out numeroUser) || (numeroUser < 1) || (numeroUser > 4)))
                {
                    Console.WriteLine("Error ! La opción no es valida");
                }

                salir = true;

            } while (!salir);


            return numeroUser;
        }

        public static void MostrarMenuProductos()
        {
            Console.Clear();
            Console.WriteLine("-En este menu se podra elegir las opciones para el catalogo de productos-");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------Menu Productos---------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1.- Añadir Producto                   -");
            Console.WriteLine("- 2.- Mostrar todos los Productos       -");
            Console.WriteLine("- 3.- Eliminar  Producto                -");
            Console.WriteLine("- 4.- Buscar Producto                    -");
            Console.WriteLine("- 5.- Salir del programa                -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
        }

        public static int PedirNumeroOpcionMenuProducto()
        {
            // Declaramos las variables
            int numeroUser = 0;
            bool salir = false;

            do
            {
                Console.WriteLine("Dime una opción para el menu");
                while ((!int.TryParse(Console.ReadLine(), out numeroUser) || (numeroUser < 1) || (numeroUser > 5)))
                {
                    Console.WriteLine("Error ! La opción no es valida");
                }

                salir = true;

            } while (!salir);


            return numeroUser;
        }

        public static void MostrarMenuLineaMaquina()
        {
            Console.Clear();
            Console.WriteLine("-En este menu se podra elegir las opciones para la Linea Máquina-");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("----------Menu Linea Máquina-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1.- Añadir Producto                   -");
            Console.WriteLine("- 2.- Mostrar todos los Productos       -");
            Console.WriteLine("- 3.- Eliminar  Producto                -");
            Console.WriteLine("- 4.- Rellenar stock                    -");
            Console.WriteLine("- 5.- Salir del programa                -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
        }

        public static int PedirNumeroOpcionMenuLineaMaquina()
        {
            // Declaramos las variables
            int numeroUser = 0;
            bool salir = false;

            do
            {
                Console.WriteLine("Dime una opción para el menu");
                while ((!int.TryParse(Console.ReadLine(), out numeroUser) || (numeroUser < 1) || (numeroUser > 5)))
                {
                    Console.WriteLine("Error ! La opción no es valida");
                }

                salir = true;

            } while (!salir);


            return numeroUser;
        }
    }
}
