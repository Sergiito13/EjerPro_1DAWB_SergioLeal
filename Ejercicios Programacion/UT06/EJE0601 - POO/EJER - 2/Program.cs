using System;

namespace ejer2
{
	class Program
	{
		public static void Main(string[] agrs)
		{
            // Declaramos las variables
            
            bool salir = false;

            do
            {
                Menu.MostrarMenu();
                int opcion = Menu.PedirNumeroOpcionMenu();

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Haz elegido la opción 1. ");
                            Funciones.AñadirProducto();   
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Haz elegido la opción 2. ");
                            Funciones.MostrarProductos();

                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Haz elegido la opción 3. ");
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Haz elegido la opcion 4");
                            salir = true;
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Saliendo del programa ...");
                            salir = true;
                        }
                        break;
                }
            }while (!salir);
            
		}
	}
}
