using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class StockMaquina
    {

        // Atributos
        private int StockProducto { get; set; }

        private string NombreProducto { get; set; }

        private decimal PrecioProducto { get; set; }

        // Constructores
        public StockMaquina(int stock, string nombreProducto, decimal precioProducto)
        {
            this.StockProducto = stock;
            this.NombreProducto = nombreProducto;
            this.PrecioProducto = precioProducto;
        }
        // Metodos

        public static List<StockMaquina> AñadirProductoMaquinaExpendedora(List<StockMaquina> maquina)
        {
            // Declaramos las variables
            List<StockMaquina> StockMaquina = new List<StockMaquina>();
            int contador = 1, stock = 10, cantidadProductos = 0;
            decimal precio = 0;
            string nombre = "", respuesta = "";
            bool salir = false, salir2 = false;
            
            do
            {
                cantidadProductos = maquina.Count;
                contador = cantidadProductos;
                do
                {
                    Console.WriteLine($"Dime un nombre para el producto {contador}");
                    nombre = Console.ReadLine();

                    if (nombre.Length > 0)
                    {
                        salir2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Error ! El nombre del producto no puede estar vacio");
                    }

                } while (!salir2);

                salir2 = false;
                do
                {
                    Console.WriteLine($"Dime el precio del producto {contador}");
                    while (!decimal.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.WriteLine("Error ! El tipo de dato tiene que ser decimal");
                    }

                    if (precio > 0)
                    {
                        salir2 = true;
                        maquina.Add(new StockMaquina(stock, nombre, precio));
                    }
                    else
                    {
                        Console.WriteLine("Error ! El precio no puede ser inferior a 0");
                    }

                } while (!salir2);

                salir2 = false;
                do
                {
                    Console.WriteLine("¿Quieres añadir otro producto? [Si | no]");
                    respuesta = Console.ReadLine();

                    if ((respuesta == "Si") || (respuesta == "si") || (respuesta == "sI") || (respuesta == "SI"))
                    {
                        salir2 = true;
                    }
                    else if ((respuesta == "No") || (respuesta == "no") || (respuesta == "nO") || (respuesta == "NO"))
                    {
                        salir2 = true;
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine($"La cadena: {respuesta} no es válido");
                    }

                } while (!salir2);

            } while ((cantidadProductos < 20) && (!salir));


            return StockMaquina;
        }
    }
}
