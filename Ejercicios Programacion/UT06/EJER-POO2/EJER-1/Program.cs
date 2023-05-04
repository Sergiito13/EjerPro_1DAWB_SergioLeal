using ejer2;

namespace ejer1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // EJER1- Partiendo del ejercicio de la máquina expendedora, realizar las siguientes modificaciones: Tendrá que existir una clase Maquina que sea quien contenga y gestione el conjunto de productos que esta tiene, así como su número máximo de líneas y la capacidad de estas. El menú, aparte de facilitar la opción de compra de productos, tendrá que ofrecer opciones para añadir un producto a la máquina(indicando tipo de producto, precio y cantidad) siempre que quede hueco, y para quitar productos que no se quieran seguir vendiendo.Todas las funciones relacionadas con añadir/ quitar productos de la máquina, así como comprobar si hay hueco para añadir nuevo producto, tendrán que estar contenidos en la clase Maquina. Para la venta de productos se tendrá que indicar en primer lugar el dinero que se va a introducir en la máquina, para poder mostrar al cliente los productos que puede comprar con el dinero introducido.En caso de elegir un producto de importe menor al introducido se tendrá que indicar cuánto dinero se ha de devolver.
            // Declaramos las variables
            List<Producto> productos = new List<Producto>();
            bool salir = false, salir2 = false, salirAñadirCliente = false;

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
                            salir2 = false;
                            do
                            {
                                Menu.MostrarMenuProductos();
                                int opcionProductos = Menu.PedirNumeroOpcionMenuProducto();

                                switch (opcionProductos)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 1, del catalogo del producto");

                                            do
                                            {
                                                string nombreProducto = Funciones.PedirNombreProducto();
                                                decimal precioProducto = Funciones.PedirPrecioProducto();

                                                productos.Add(new Producto(nombreProducto, precioProducto));
                                                Console.WriteLine("Se ha añadido correctamente el producto");
                                                Console.WriteLine("");
                                                Console.WriteLine("---------------------------------------");

                                                bool salirPregunta = false;
                                                do
                                                {
                                                    

                                                    Console.WriteLine("¿Quieres añadir otro producto? [si | no]");
                                                    string preguntaSeguir = Console.ReadLine();

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
                                                } while (!salirPregunta);
                                            } while (!salirAñadirCliente);
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 2, del catalogo del producto");
                                            Console.ReadKey();

                                            Funciones.MostrarProductosCatalogo(productos);
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 3, del catalogo del producto");
                                            Console.ReadKey();

                                            Funciones.EliminarProductoCatalogo(productos);
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 4, del catalogo del producto");
                                            Console.ReadKey();

                                            Funciones.BuscarNombreProducto(productos);
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Saliendo...");
                                            Console.ReadKey();
                                            salir2 = true;
                                        }
                                        break;

                                }

                            } while (!salir2);


                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido la opción 2. ");
                            salir2 = false;

                            do
                            {
                                Menu.MostrarMenuLineaMaquina();
                                int opcionLineaMaquina = Menu.PedirNumeroOpcionMenuLineaMaquina();

                                switch (opcionLineaMaquina)
                                {
                                    case 1:
                                        {
                                            if (productos.Count > 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Has elegido la opcion 1, de la linea de la máquina");

                                                Funciones.MostrarProductosCatalogo(productos);
                                                Console.WriteLine("");

                                                bool correcto = false;
                                                do
                                                {
                                                    Console.WriteLine("Dime el ID, del producto que quieras añadir a la máquina");
                                                    Producto productoID = Funciones.ExisteIdProducto(productos);

                                                    if (!(productoID == null))
                                                    {
                                                        Console.WriteLine("IDENCONTRADO");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("El Id elegido no se ha encontrado");
                                                    }

                                                } while (!correcto);
                                                

                                                Console.WriteLine("Dime el producto que quieres añadir. Pon el ID");
                                            }
                                            else
                                            {
                                                Console.WriteLine("No se ha encontrado ningun producto");
                                            }
                                            

                                            Console.ReadKey();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 2, de la linea de la máquina");
                                            Console.ReadKey();
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 3, de la linea de la máquina");
                                            Console.ReadKey();
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 4, de la linea de la máquina");
                                            Console.ReadKey();
                                        }
                                        break;
                                    case 5:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Saliendo...");
                                            Console.ReadKey();
                                            salir2 = true;
                                        }
                                        break;
                                }
                            } while (!salir2);

                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido la opción 3. Qué es comprar un producto");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
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