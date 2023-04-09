using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Funciones
    {

        public static string[] PrecioProductoMaquinaExpendedora()
        {
            // Declaramos las variables
            decimal[] precioProducto = new decimal[0];
            decimal precio = "";
            const int NUMERO_MAXIMO_PRODUCTO = 20;
            int contador = 1;
            bool salir = false, salirPregunta = false;


            do
            {
                Console.WriteLine($"Dime un nombre para el producto {contador}");
                nombre = Console.ReadLine();

                if (nombre.Length > 0)
                {
                    Array.Resize(ref precioProducto, precioProducto.Length + 1);
                    precioProducto[contador - 1] = nombre;
                }
                else
                {
                    Console.WriteLine("Error ! El nombre del producto no puede estar vacio");
                }


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

            return precioProducto;
        }
    }
}
