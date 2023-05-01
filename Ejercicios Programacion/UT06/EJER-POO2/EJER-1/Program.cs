﻿using ejer2;

namespace ejer1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // EJER1- Partiendo del ejercicio de la máquina expendedora, realizar las siguientes modificaciones: Tendrá que existir una clase Maquina que sea quien contenga y gestione el conjunto de productos que esta tiene, así como su número máximo de líneas y la capacidad de estas. El menú, aparte de facilitar la opción de compra de productos, tendrá que ofrecer opciones para añadir un producto a la máquina(indicando tipo de producto, precio y cantidad) siempre que quede hueco, y para quitar productos que no se quieran seguir vendiendo.Todas las funciones relacionadas con añadir/ quitar productos de la máquina, así como comprobar si hay hueco para añadir nuevo producto, tendrán que estar contenidos en la clase Maquina. Para la venta de productos se tendrá que indicar en primer lugar el dinero que se va a introducir en la máquina, para poder mostrar al cliente los productos que puede comprar con el dinero introducido.En caso de elegir un producto de importe menor al introducido se tendrá que indicar cuánto dinero se ha de devolver.
            // Declaramos las variables
            List<Producto> products = new List<Producto>();
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
                            Console.WriteLine("Has elegido la opción 1. ");
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido la opción 2. ");
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido la opción 3. ");
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido la opcion 4");
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido la opcion 5");

                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Saliendo del programa ...");
                            salir = true;
                        }
                        break;
                }

            } while (!salir);
        }
    }
}