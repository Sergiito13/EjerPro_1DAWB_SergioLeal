namespace ejer1
{
    class Funciones
    {
        // ----------------------ESTAS FUNCIONES SON PARA METER LOS PRODUCTOS AL CATALOGO----------------------
        private static int IDAutoIncremental = 1; // Pongo el valor de la variable a 1

        public static int GenerateId() // Llamo a esta funcion que la incrementara
        {
            return IDAutoIncremental++;
        }

        public static string PedirNombreProducto()
        {
            // Declaramos las variables
            string nombreProducto = "";
            bool salir = false;

            do
            {
                Console.WriteLine("Dime el nombre del producto");
                nombreProducto = Console.ReadLine();

                if (nombreProducto.Length > 0)
                {
                    nombreProducto = nombreProducto.Trim();
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! El nombre no es valido");
                }
            } while (!salir);

            return nombreProducto;
        }

        public static decimal PedirPrecioProducto()
        {
            // Declaramos las variables
            decimal precioProducto = 0;
            bool salir = false;

            do
            {

                Console.WriteLine("Dime el precio del producto");
                while ((!decimal.TryParse(Console.ReadLine(), out precioProducto) || (precioProducto < 0)))
                {
                    Console.WriteLine("Error el precio no es valido");
                }
                salir = true;
            } while (!salir);
            return precioProducto;
        }

        // ------------------------------------------------------------------------------------------
        // Funcion para mostrar los productos
        public static void MostrarProductosCatalogo(List<Producto> productos)
        {
            Console.Clear();
            Console.WriteLine("| LISTA DE PRODUCTOS: ");
            Console.WriteLine("---------------------------");

            productos.ForEach(producto => Console.WriteLine(producto.ToString()));
            /*foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }*/
            Console.WriteLine("---------------------------");
            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
        }
        //------------------------------------------------------------------------------------------
        // Funcion para eliminar producto
        public static void EliminarProductoCatalogo(List<Producto> productos)
        {
            if (productos.Count > 0)
            {
                
                MostrarProductosCatalogo(productos);
                Console.WriteLine("");
                Console.WriteLine("Para Eliminar productos, tienes que poner su ID");

                int IDProductoEliminar = PedirIDEliminar();

                productos.RemoveAll(producto => producto.GetID() == IDProductoEliminar);

            }
            else
            {
                Console.WriteLine("No se ha encontrado productos, añada productos");
            }
            Console.ReadKey();
        }

        public static int PedirIDEliminar()
        {
            int IDProductoEliminar = 0;

            while (!int.TryParse(Console.ReadLine(), out IDProductoEliminar) || (IDProductoEliminar <= 0))
            {
                Console.WriteLine("Error ! No es válido el dato introducido. Prueba otra vez");
            }
            return IDProductoEliminar;
        }
    }
}
