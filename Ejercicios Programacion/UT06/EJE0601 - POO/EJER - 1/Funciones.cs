using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class Funciones
    {
        public static int ObtenerIDNuevoCliente(List<Clientes> cliente)
        {
            // Declaramos las variables
            int IDCliente = 0;

            foreach (Clientes client in cliente)
            {
                IDCliente = client.GetID();
            }

            return IDCliente;
        }

        public static string PedirNombreCliente()
        {
            // Declaramos las variables
            string nombreCliente;
            bool salir = false;

            do
            {
                Console.WriteLine("Dime el nombre del cliente");
                nombreCliente = Console.ReadLine();

                if ((nombreCliente.Length > 0) || (nombreCliente != null))
                {
                    nombreCliente = nombreCliente.Trim();
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! La cadena no puede estar vacia");
                }

            } while (!salir);

            return nombreCliente;
        }

        public static string PedirApellidoCliente()
        {
            // Declaramos las variables
            string apellidoCliente;
            bool salir = false;

            do
            {
                Console.WriteLine("Dime el apellido del cliente");
                apellidoCliente = Console.ReadLine();

                if ((apellidoCliente.Length > 0) || (apellidoCliente != null))
                {
                    apellidoCliente = apellidoCliente.Trim();
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! La cadena no puede estar vacia");
                }

            } while (!salir);
            return apellidoCliente;
        }

        public static void AñadirNuevoCliente()
        {
            // Declaramos las variables
            List<Clientes> cliente = new List<Clientes>();

            int IDCliente = ObtenerIDNuevoCliente(cliente);
            string nombreCliente = PedirNombreCliente();
            string apellidoCliente = PedirApellidoCliente();

            Clientes nuevoCliente = new Clientes(IDCliente, nombreCliente, apellidoCliente);
            cliente.Add(nuevoCliente);

            // cliente.Add(new Clientes(IDCliente, nombreCliente, apellidoCliente));
        }

    }
}
