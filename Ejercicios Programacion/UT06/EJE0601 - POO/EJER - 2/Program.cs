using System;

namespace ejer2
{
	class Program
	{
		public static void Main(string[] agrs)
		{
            // Declaramos las variables
            List<Productos> products = new List<Productos>();
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
                            const int NUMERO_MAXIMO_PRODUCTO = 20, stockProductos = 10;
                            int ID = 0, contador = 0;
                            string nombreProducto = "", preguntaSeguir = "";
                            decimal precioProducto = 0;

                            do
                            {
                                ID = Funciones.SacarIDProducto(products);
                                contador = ID;

                                nombreProducto = Funciones.PedirNombreProducto();
                                precioProducto = Funciones.PedirPrecioProducto();

                                ID++;
                                Productos productoAux = new Productos(ID, nombreProducto, precioProducto, stockProductos);
                                products.Add(productoAux);
                                /*products.Add(new Productos(ID, nombreProducto, precioProducto, stockProductos));*/
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
                            Funciones.MostrarProductos(products);

                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Haz elegido la opción 3. ");
                            Funciones.MostrarProductos(products);

                            // Declaramos las variables
                            int EleccionCliente = 0;
                            bool salirPedirDinero = false;
                            decimal dinero = 0;
                            decimal vuelto = 0;



                            int maxID = Funciones.SacarIDProducto(products);
                            Console.WriteLine("Elige el id del producto que quieres comprar");
                            while (!int.TryParse(Console.ReadLine(), out EleccionCliente) || (EleccionCliente < 1) || (EleccionCliente > maxID))
                            {
                                Console.WriteLine("Error ! En la selección del producto");
                                Console.Clear();
                                Console.WriteLine("Elige el id del producto que quieres comprar");
                            }
                            EleccionCliente--;
                            Console.Clear();
                            Console.WriteLine($"El producto seleccionado es: {products[EleccionCliente].ToString()}");
                            Console.WriteLine($"El precio es de: {products[EleccionCliente].Getprecio()}");
                            Console.WriteLine("");

                            salirPedirDinero = false;
                            do
                            {
                                dinero = Funciones.PedirDineroUsuario(dinero);

                                if (products[EleccionCliente].Getprecio() > dinero)
                                {
                                    Console.WriteLine("El dinero es insuficiente, añada lo que falta");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    vuelto = products[EleccionCliente].Getprecio() - dinero;
                                    Console.WriteLine($"El vuelto es de: {Math.Abs(vuelto)}");
                                    salirPedirDinero = true;
                                }


                            } while (!salirPedirDinero);

                            int stockProductoSeleccionado = products[EleccionCliente].GetStock();
                            if (stockProductoSeleccionado > 0)
                            {
                                stockProductoSeleccionado--;
                                products[EleccionCliente].SetStockProducto(stockProductoSeleccionado);
                            }
                            else
                            {
                                Console.WriteLine("Error! no tenemos este producto disponible");
                            }
                            Console.ReadKey();

                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Haz elegido la opcion 4");

                            foreach (Productos product in products)
                            {
                                product.SetStockProducto(10);
                            }
                            Console.WriteLine("Se ha rellenado todos los productos correctamente");
                            Console.ReadKey();
                            
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
