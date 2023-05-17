using System;
namespace tiendaonline
{
	class Program
	{
		public static void Main(string[] agrs)
		{
			// Creamos la instancia de la tienda
			List<Carrito> carritocompra = new List<Carrito>();
			Tienda tienda = new Tienda("Tiendita", carritocompra);

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente("Ana García", "ana@example.com"));
            clientes.Add(new Cliente("Carlos López", "carlos@example.com"));
            clientes.Add(new Cliente("María Rodríguez", "maria@example.com"));

            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("Laptop HP", 1499.99m, 8));
            productos.Add(new Producto("Smartphone Samsung Galaxy S21", 999.99m, 12));
            productos.Add(new Producto("Tablet Apple iPad Air", 649.99m, 5));
            
            List<Carrito> ordenes = new List<Carrito>();

            /*clientes.ForEach(cliente => Console.WriteLine(cliente.ToString()));
            productos.ForEach(producto => Console.WriteLine(producto.ToString()));*/

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("=== Menú ===");
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Mostrar clientes");
                Console.WriteLine("3. Agregar producto");
                Console.WriteLine("4. Mostrar productos");
                Console.WriteLine("5. Realizar orden de compra");
                Console.WriteLine("6. Mostrar órdenes de compra");
                Console.WriteLine("7. Salir");
                Console.WriteLine("==============");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:

                        Console.Write("Ingrese el nombre del cliente: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese el email del cliente: ");
                        string email = Console.ReadLine();

                        clientes.Add(new Cliente(nombre, email));

                        Console.WriteLine("Cliente agregado exitosamente.");

                        break;
                    case 2:
                        clientes.ForEach(cliente => Console.WriteLine(cliente.ToString()));
                        break;
                    case 3:

                        Console.Write("Ingrese el nombre del producto: ");
                        string nombreP = Console.ReadLine();

                        Console.Write("Ingrese el precio del producto: ");
                        decimal precio = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Ingrese el stock del producto: ");
                        int stock = Convert.ToInt32(Console.ReadLine());

                        productos.Add(new Producto(nombreP, precio, stock));

                        Console.WriteLine("Producto agregado exitosamente.");

                        break;
                    case 4:
                        
                        productos.ForEach(producto => Console.WriteLine(producto.ToString()));

                        break;
                    case 5:

                        
                        break;
                    case 6:
                        
                        break;
                    case 7:
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }

            
        }
	}
}
