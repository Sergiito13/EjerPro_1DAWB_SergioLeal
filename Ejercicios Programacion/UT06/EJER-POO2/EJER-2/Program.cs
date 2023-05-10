namespace ejer2
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // EJER2 | La cafeteria del centro
            // Declaramos las variables
            List<Producto> productos = new List<Producto>();
            List<Pedido> pedidos = new List<Pedido>();

            // Llenamos la lista de productos
            productos.Add(new Producto("Bocadillo Mixto", 2.10m));
            productos.Add(new Producto("Agua mineral", 0.70m));
            productos.Add(new Producto("Refresco de cola", 1.00m));
            productos.Add(new Producto("Zumo de naranja", 0.90m));
            productos.Add(new Producto("Café con leche", 1.20m));
            productos.Add(new Producto("Té con limón", 1.00m));
            productos.Add(new Producto("Bocadillo de lomo con queso", 2.80m));
            productos.Add(new Producto("Croissant de jamón y queso", 1.80m));
            productos.Add(new Producto("Yogur con cereales", 1.10m));
            productos.Add(new Producto("Batido de chocolate", 1.50m));
            productos.Add(new Producto("Magdalenas caseras", 0.80m));
            productos.Add(new Producto("Bocadillo Mixto", 2.10m));
            productos.Add(new Producto("Bocadillo de jamón ibérico", 2.90m));
            productos.Add(new Producto("Bocadillo de atún con tomate", 3.20m));
            productos.Add(new Producto("Bocadillo vegetal con hummus", 2.80m));
            productos.Add(new Producto("Sandwich de pollo y aguacate", 4.50m));
            productos.Add(new Producto("Sandwich de queso a la plancha", 3.80m));
            productos.Add(new Producto("Croissant de jamón y queso", 1.80m));
            productos.Add(new Producto("Croissant de chocolate", 1.50m));
            productos.Add(new Producto("Croissant de almendras", 1.60m));
            productos.Add(new Producto("Café americano", 1.20m));
            productos.Add(new Producto("Café cortado", 1.20m));
            productos.Add(new Producto("Café con hielo", 1.50m));
            productos.Add(new Producto("Café con leche y caramelo", 2.00m));
            productos.Add(new Producto("Café con leche y canela", 1.80m));
            productos.Add(new Producto("Capuccino", 2.00m));
            productos.Add(new Producto("Café solo", 1.00m));
            //-------------------------------------------------------------------


            productos.ForEach(producto => Console.WriteLine(producto.ToString()));

            bool salir = false;
            do
            {
                Menu.MostrarMenu();
                int opcion = Menu.PedirNumeroOpcionMenu();

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("\nSeleccionó la opción 1. Para añadir un pedido\n");
                            Console.ReadKey();
                            List<Producto> productosSeleccionados = new List<Producto>();

                            bool salirAñadirPedido = false;
                            

                            do
                            {
                                bool ProductoExiste = false;

                                if (pedidos.Count <= Pedido.NUMERO_MAXIMO_PEDIDO)
                                {
                                    do
                                    {
                                        Producto.MostrarProductos(productos);

                                        int IDElegido = Producto.PedirIdProducto();

                                        Producto eleccionProducto = Producto.ComprobarIDExiste(productos, IDElegido);
                                        if (!(eleccionProducto == null))
                                        {
                                            productosSeleccionados.Add(eleccionProducto);
                                            ProductoExiste = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("El ID, seleccionado no existe, Intentelo de nuevo");
                                        }
                                    } while (!ProductoExiste);

                                    if (Funciones.PedirRespuestaSeguir())
                                    {
                                        Console.WriteLine("Ha decidido seguir comprando");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ha decidido no seguir comprando");
                                        pedidos.Add(new Pedido(productosSeleccionados, DateTime.Now));
                                        Console.Clear();
                                        Pedido.MostrarPedidoAcabadoDeIntroducir(pedidos);
                                        Console.ReadKey();
                                        salirAñadirPedido = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("La cola de pedido esta llena");
                                }
                            } while (!salirAñadirPedido);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\nSeleccionó la opción 2.\n");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\nSeleccionó la opción 3.\n");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\nAdiós!\n");
                            Console.ReadKey();
                            salir = true;
                        }
                        break;
                }

            } while (!salir);
        }
    }
}
