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

        // Metodos

        public static List<StockMaquina> AñadirProductoMaquinaExpendedora()
        {
            // Declaramos las variables
            List<StockMaquina> StockMaquina = new List<StockMaquina>();
            int contador = 1;
            string nombre = "", respuesta = "";
            bool salir = false, salir2 = false;

            do
            {
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


                } while (!salir2);

                do
                {
                    Console.WriteLine("¿Quieres añadir otro producto? [Si | no]");
                    respuesta = Console.ReadLine();

                    if ((respuesta == "Si") || (respuesta == "si") || (respuesta == "sI") || (respuesta == "SI"))
                    {
                        salirPregunta = false;
                    }
                    else if ((respuesta == "No") || (respuesta == "no") || (respuesta == "nO") || (respuesta == "NO"))
                    {
                        salirPregunta = true;
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine($"La cadena: {respuesta} no es válido");
                    }

                } while (!salirPregunta);

            } while (contador < 20 || !salir);


            return StockMaquina;
        }
    }
}
