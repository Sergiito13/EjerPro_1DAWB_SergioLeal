using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TienditaPOSTAPOCALIPTICA
{
    class Funciones
    {
        
        public static Estructuras.UsuariosTienda[] LlenarUsuariosTienda() // ESTA FUNCION PEDIRA LOS DATOS DE LOS CLIENTES
        {
            // Declaramos las variables
            Estructuras.UsuariosTienda[] UsuariosTienda = new Estructuras.UsuariosTienda[0];
            int NumeroClientesAñadir = 0, ContadorPosiciones = 0, EdadUser = 0;
            string NombreUsuario = "";
            decimal MoneyUsuario = 0;
            bool Salir = false;


            do
            {
                Console.WriteLine("¿Cuántos Clientes quieres añadir?");
                while (!int.TryParse(Console.ReadLine(), out NumeroClientesAñadir))
                {
                    Console.WriteLine("Error ! El dato tiene que ser de tipo entero");
                }
                if (NumeroClientesAñadir > 0)
                {
                    Salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! No se acepta un numero negativo");
                }
            } while (!Salir);

            Salir= false;
            for (int i = 0; i < NumeroClientesAñadir; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Dime un nombre para el usuario {i+1}");
                    NombreUsuario = Console.ReadLine();

                    if (NombreUsuario.Length > 0)
                    {
                        Array.Resize(ref UsuariosTienda, UsuariosTienda.Length+1);
                        UsuariosTienda[ContadorPosiciones].NombreUsuario = NombreUsuario;
                        Salir= true;
                    }
                    else
                    {
                        Console.WriteLine("Error ! La cadena no puede estar vacia");
                    }

                } while (!Salir);

                Salir= false;
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Dime la edad para el usuario {i + 1}");
                    while (!int.TryParse(Console.ReadLine(), out EdadUser))
                    {
                        Console.WriteLine("Error ! La edad tiene que ser un número entero");
                    }

                    if ((EdadUser > 0)  && (EdadUser < 130))
                    {
                        UsuariosTienda[ContadorPosiciones].EdadUsuario = EdadUser;
                        Salir= true;
                    }
                    else
                    {
                        Console.WriteLine("Error ! La edad tiene que estar entre 0 y 130");
                    }
                } while (!Salir);

                Salir = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Dime el MONEY que tiene el usuario {i + 1}");
                    while (!decimal.TryParse(Console.ReadLine(), out MoneyUsuario))
                    {
                        Console.WriteLine("Error ! El dinero tiene que ser un dato numérico");
                    }

                    if (MoneyUsuario > 0)
                    {
                        MoneyUsuario = Math.Round(MoneyUsuario, 2);
                        UsuariosTienda[ContadorPosiciones].SaldoUsuario = MoneyUsuario;
                        ContadorPosiciones++;
                        Salir = true;
                    }
                    else
                    {
                        Console.WriteLine("Error ! El dinero no puede ser negativo");
                    }
                } while (!Salir);
            }
            return UsuariosTienda;
            

        }
    
        public static Estructuras.ProductosTienda[] ProductosDeLaTiendaPOSTAPOCALIPTICA() // ESTA FUNCION ALMACENARA EN LA ESTRUCTURA LOS PRODUCTOS DE LA TIENDA 
        {
            //Declaramos las variables
            string[] NombreProductos = new string[] {"Agua Botella", "Lata Atun", "Munición", "Mantas", "Paracetamol"};
            decimal[] PrecioProductos = new decimal[] {25,51m, 15, 90.99m, 10.50m, 75 };
            int[] StockProductos = new int[] { 20, 5, 200, 10, 99 };
            int ContadorPosiciones = 0;
            Estructuras.ProductosTienda[] ProductosShop =  new Estructuras.ProductosTienda[0];

            for (int i = 0; i < NombreProductos.Length; i++)
            {
                Array.Resize(ref ProductosShop, ProductosShop.Length+1);
                ProductosShop[ContadorPosiciones].NombreProducto = NombreProductos[i];
                ProductosShop[ContadorPosiciones].PrecioProducto = PrecioProductos[i];
                ProductosShop[ContadorPosiciones].StockProducto = StockProductos[i];
                ContadorPosiciones++;
            }
            return ProductosShop;

        }  
    
        public static List<Estructuras.Pedidos> NuevoPedido(Estructuras.UsuariosTienda[] UserShop, Estructuras.ProductosTienda[] ProductShop) // ESTA FUNCION AÑADIRA UN NUEVO PEDIDO 
        {
            // Declaramos las variables
            bool Salir = false;
            string NameUserValido = "";

            List<Estructuras.Pedidos> pedidos = new List<Estructuras.Pedidos>();

            Console.WriteLine("Los nombres validos de usuarios son: ");
            do
            {
                for (int i = 0; i < UserShop.Length; i++)
                {
                    Console.Write($" {UserShop[i].NombreUsuario} ");

                }

                Console.WriteLine("Dime un nombre de usuario");
                NameUserValido= Console.ReadLine();

                if (NameUserValido.Length > 0)
                {
                    for (int i = 0; i < UserShop.Length; i++)
                    {
                        if (UserShop[i].NombreUsuario == NameUserValido)
                        {
                            Console.WriteLine($"El usuario es correcto y ha elegido {NameUserValido}");
                            Salir = true;
                        }
                        else
                        {
                            Console.WriteLine("Error! El nombre de usuario no existe");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error ! La cadena introducida no puede estar vacia ");
                }
            } while (!Salir);

            Console.WriteLine("\nLos productos Disponibles son: ");

            foreach (Estructuras.ProductosTienda producto in ProductShop)
            {
                if (producto.StockProducto > 1)
                {
                    Console.Write($" {producto.NombreProducto} ");
                    Console.Write($" {producto.PrecioProducto} ");
                    Console.Write($" {producto.StockProducto} ");
                }
            }
            Salir = false;

            do
            {
                Console.WriteLine($"\nUser {NameUserValido} que producto quiere comprar?");

            } while (!Salir);
        }
    }
}
