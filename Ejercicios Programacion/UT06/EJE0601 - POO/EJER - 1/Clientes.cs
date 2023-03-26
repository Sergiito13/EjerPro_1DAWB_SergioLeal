using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class Clientes
    {
        // Atributos

        private int IDCliente { get; set; }

        private string nombreCliente { get; set; }

        private string apellidoCliente { get; set; }

        // Constructores
        public Clientes(int IDCliente,string nombreCliente,string apellidoCliente)
        {
            this.IDCliente = IDCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
        }

        public int GetID()
        {
            return this.IDCliente;
        }

        public string  GetNombre()
        {
            return this.nombreCliente;
        }

        public string GetApellido()
        {
            return this.apellidoCliente;
        }
        // Metodos

        public static List<Clientes> AñadirNuevoCliente(List<Clientes> cliente)
        {
            // Declaramos las variables

            bool salir = false;
            string nombreCliente = "", apellidoCliente = "";
            int IDCliente = 0;

            foreach (Clientes client in cliente)
            {
                IDCliente = client.GetID();
            }

            IDCliente++;
            

            do
            {
                Console.WriteLine("Dime un nombre para el cliente");
                nombreCliente = Console.ReadLine();

                if (nombreCliente.Length > 0)
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error! La cadena no puede estar vacia. Intentelo de nuevo");
                }
            } while (!salir);

            salir = false;

            do
            {
                Console.WriteLine("Dime un apellido para el cliente");
                apellidoCliente = Console.ReadLine();

                if (apellidoCliente.Length > 0)
                {
                    salir = true;
                    cliente.Add(new Clientes(IDCliente, nombreCliente, apellidoCliente));
                }
                else
                {
                    Console.WriteLine("Error ! La cadena no puede estar vacia");
                }

            } while (!salir);
            Console.Clear();
            Console.WriteLine($"Se ha añadido correctamente el cliente con el ID:{IDCliente}, el nombre: {nombreCliente} y el apellido: {apellidoCliente}");
            Console.WriteLine("Pulsa una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            return cliente;
        }

        public static void BuscarSiNombreExiste(List<Clientes> cliente)
        {
            // Declaramos las variables
            bool salir = false, nombreExiste = false;
            string cadenaUsu = "", clienteLista = "";
            int contadorVecesExiste = 0;


            do
            {
                Console.WriteLine("Dime un nombre y te dire si se encuentra en la lista");
                cadenaUsu = Console.ReadLine();

                if (cadenaUsu.Length > 0)
                {
                    foreach (Clientes client in cliente)
                    {
                        if (cadenaUsu == client.GetNombre())
                        {
                            nombreExiste = true;
                            contadorVecesExiste++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error la cadena no puede estar vacia");
                }

                if (nombreExiste)
                {
                    Console.Clear();
                    Console.WriteLine($"El nombre {cadenaUsu} si existe en la lista y esta {contadorVecesExiste} veces");
                    
                }
                else
                {
                    Console.WriteLine("El nombre no esta en la lista");
                }
                salir = true;

            } while (!salir);
            
        }

        public static void MostrarClientesLista(List<Clientes> cliente)
        {
            // Declaramos las variables
            Console.WriteLine("Lista de los clientes: ");

            foreach (Clientes client in cliente)
            {
                Console.WriteLine("---------------------------");

                Console.WriteLine(client.GetID());
                Console.WriteLine(client.GetNombre());
                Console.WriteLine(client.GetApellido());

                Console.WriteLine("---------------------------");

            }
            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void EliminarClienteLista(List<Clientes> cliente)
        {
            // Declaramos las variables
            int eleccionUsuario = 0, IDCliente = 0;
            

            if (cliente.Count > 0)
            {
                MostrarClientesLista(cliente);
                Console.WriteLine("¿Qué cliente quieres eliminar? (Tienes que poner el ID, del usuario que quieres eliminar)");

                foreach (Clientes client in cliente)
                {
                    IDCliente = client.GetID();
                }
                while (!int.TryParse(Console.ReadLine(), out eleccionUsuario) || (eleccionUsuario <= 0) || (eleccionUsuario > IDCliente))
                {
                    Console.WriteLine("ERROR ! El ID introduccido no pertenece a ningun usuario");
                }

                cliente.RemoveAll(c => c.IDCliente == eleccionUsuario);
            }
            else
            {
                Console.WriteLine("No hay ningun usaurio en la lista. LO SIENTO");
            }
            
        }
    }
}
