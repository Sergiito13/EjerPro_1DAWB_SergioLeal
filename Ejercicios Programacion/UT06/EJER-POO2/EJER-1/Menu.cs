namespace ejer2
{
    class Menu
    {

        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------Menu--------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1.- Añadir Producto                   -");
            Console.WriteLine("- 2.- Quitar Producto                   -");
            Console.WriteLine("- 3.- Mostrar productos                 -");
            Console.WriteLine("- 4.- Comprar producto                  -");
            Console.WriteLine("- 5.- Rellenar productos                -");
            Console.WriteLine("- 6.- Salir                             -");
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
