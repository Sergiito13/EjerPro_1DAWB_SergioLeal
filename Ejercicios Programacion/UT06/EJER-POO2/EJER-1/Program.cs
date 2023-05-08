using ejer2;
using System.Dynamic;

namespace ejer1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // EJER1- Partiendo del ejercicio de la máquina expendedora, realizar las siguientes modificaciones: Tendrá que existir una clase Maquina que sea quien contenga y gestione el conjunto de productos que esta tiene, así como su número máximo de líneas y la capacidad de estas. El menú, aparte de facilitar la opción de compra de productos, tendrá que ofrecer opciones para añadir un producto a la máquina(indicando tipo de producto, precio y cantidad) siempre que quede hueco, y para quitar productos que no se quieran seguir vendiendo.Todas las funciones relacionadas con añadir/ quitar productos de la máquina, así como comprobar si hay hueco para añadir nuevo producto, tendrán que estar contenidos en la clase Maquina. Para la venta de productos se tendrá que indicar en primer lugar el dinero que se va a introducir en la máquina, para poder mostrar al cliente los productos que puede comprar con el dinero introducido.En caso de elegir un producto de importe menor al introducido se tendrá que indicar cuánto dinero se ha de devolver.
            // Declaramos las variables
            List<Producto> productos = new List<Producto>();
            List<LineaMaquina> lineamaquina = new List<LineaMaquina>();
            bool salir = false, salir2 = false, salirAñadirCliente = false;
            const int NUMEROMAXIMODELINEAS = 20;

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

                                            int cont = 0;




                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 1, de la linea de la máquina");
                                            if (productos.Count > 0)
                                            {

                                                Funciones.MostrarProductosCatalogo(productos);
                                                Console.WriteLine("");

                                                bool correcto = false;
                                                do
                                                {
                                                    cont = lineamaquina.Count;

                                                    if (cont < NUMEROMAXIMODELINEAS)
                                                    {
                                                        Console.WriteLine("Dime el ID, del producto que quieras añadir a la máquina");
                                                        Producto productoSeleccionado = Funciones.ExisteIdProducto(productos);

                                                        if (!(productoSeleccionado == null))
                                                        {
                                                            int stockProduct = Funciones.PedirStockProductoParaMaquina();

                                                            lineamaquina.Add(new LineaMaquina(productoSeleccionado, stockProduct));

                                                            Console.WriteLine("Se ha añadido correctamente el producto a la linea de máquina");

                                                            bool salirPregunta = false;
                                                            do
                                                            {
                                                                if (cont < NUMEROMAXIMODELINEAS)
                                                                {
                                                                    Console.WriteLine("");
                                                                    Console.WriteLine("¿Quieres añadir otro producto a la máquina? [si | no]");
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
                                                                            correcto = true;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Error! La respuesta no puede estar vacia");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Ya se ha introducido todas las lineas de la máquina");
                                                                    salirPregunta = true;
                                                                    correcto = true;
                                                                }
                                                            } while (!salirPregunta);
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("El Id elegido no se ha encontrado");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Se ha añadido todos los productos a la linea");
                                                        correcto = true;
                                                        
                                                    }
                                                } while (!correcto);
                                            }
                                            else
                                            {
                                                Console.WriteLine("No se ha encontrado ningun producto");
                                            }


                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 2, de la linea de la máquina");
                                            Funciones.MostrarProductosLineaMaquina(lineamaquina);
                                            Console.ReadKey();
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 3, de la linea de la máquina");
                                            Funciones.EliminarProductoLineaMaquina(lineamaquina);
                                            Console.ReadKey();
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Has elegido la opcion 4, de la linea de la máquina");
                                            Funciones.RellenarProductosLista(lineamaquina);
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
                            List<LineaMaquina> productosvalido = new List<LineaMaquina>();

                            decimal dinero = Funciones.PedirDineroUsuario();
                            productosvalido = Funciones.SacarProductosValidos(lineamaquina, dinero);

                            productosvalido.ForEach(aptos => Console.WriteLine(aptos.ToString()));
                            Console.ReadKey();

                            Console.WriteLine("¿Qué objeto quieres comprar?");
                            LineaMaquina lineaSeleccionada = Funciones.ExisteIdLineaMaquina(productosvalido);

                            if (!(lineaSeleccionada == null))
                            {
                                Console.WriteLine($"Tu vuelto es de: {Math.Abs(lineaSeleccionada.GetProductoLinea().Getprecio() - dinero)}");

                                lineaSeleccionada.SetStock(lineaSeleccionada.Getstock()-1);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("La linea no existe o no te da el dinero para el producto");
                            }

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