using System;

namespace ejer2
{
	class Program
	{
		public static void Main(string[] agrs)
		{
            // Declaramos las variables
            List<Productos> product = new List<Productos>();
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

                            // Declaramos las variables
                            bool salirAñadirCliente = false, salirPregunta = false;
                            const int NUMERO_MAXIMO_PRODUCTO = 2, stockProductos = 10;
                            int ID = 0, contador = 0;
                            string nombreProducto = "", preguntaSeguir = "";
                            decimal precioProducto = 0;

                            do
                            {
                                ID = Funciones.SacarIDProducto();
                                contador = ID;

                                nombreProducto = Funciones.PedirNombreProducto();
                                precioProducto = Funciones.PedirPrecioProducto();

                                ID++;
                                Productos productoAux = new Productos(ID + 1, nombreProducto, precioProducto, stockProductos);
                                product.Add(productoAux);
                                /*product.Add(new Productos(ID, nombreProducto, precioProducto, stockProductos));*/
                                Console.WriteLine("Se ha añadido correctamente el producto");
                                Console.WriteLine("");
                                Console.WriteLine("---------------------------------------");

                                salirPregunta = false;
                                do
                                {
                                    if (contador < NUMERO_MAXIMO_PRODUCTO)
                                    {
                                        Console.WriteLine("¿Quieres añadir otro producto? [si | no]");
                                        preguntaSeguir = Console.ReadLine();

                                        if (preguntaSeguir.Length > 0)
                                        {
                                            if ((preguntaSeguir == "si") || (preguntaSeguir == "Si") || (preguntaSeguir == "SI") || (preguntaSeguir == "sI"))
                                            {
                                                salirPregunta = true;
                                            }
                                            else if ((preguntaSeguir == "no") || (preguntaSeguir == "No") || (preguntaSeguir == "NO") || (preguntaSeguir == "nO"))
                                            {
                                                Console.WriteLine("Ha decidido no añadir más producto");
                                                salirPregunta = true;
                                                salirAñadirCliente = true;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Error! La respuesta no puede estar vacia");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ya haz añadido todos los productos");
                                        salirAñadirCliente = true;
                                        salirPregunta = true;
                                    }
                                } while (!salirPregunta);


                            } while (!salirAñadirCliente && contador < NUMERO_MAXIMO_PRODUCTO);


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
