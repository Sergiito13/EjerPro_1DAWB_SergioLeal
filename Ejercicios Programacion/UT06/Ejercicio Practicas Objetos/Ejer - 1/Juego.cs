using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class Juego
    {
        // Atributos
        private string nombre { get; set; }
        private decimal precio { get; set; }
        private string genero { get; set; }

        // Constructores

        public Juego(string nombre,decimal precio, string genero)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
        }

        // Metodos
        public string GetNombre()
        {
            return this.nombre;
        }

        public decimal GetPrecio()
        {
            return this.precio;
        }
        public string GetGenero()
        {
            return this.genero;
        }


        public static List<Juego> AñadirNuevoJuego(List<Juego> juegos)
        {
            // Declaramos las variables
            
            bool salir = false;
            string nombreJuego = "", generoJuego = "";
            decimal precioJuego = 0;

            do
            {
                Console.WriteLine("Dime un nombre de un juego");
                nombreJuego = Console.ReadLine();

                if (nombreJuego.Length > 0)
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error! La cadena no puede estar vacia");
                }
            } while (!salir);

            salir = false;

            do
            {
                Console.WriteLine("Dime un precio para el juego nuevo");
                while (!decimal.TryParse(Console.ReadLine(), out precioJuego))
                {
                    Console.WriteLine("Error ! Tiene que ser de tipo decimal el dato");
                }
                if (precioJuego > 0)
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! El precio no puede ser negativo");
                }

            } while (!salir);

            salir = false;

            do
            {
                Console.WriteLine("Dime un genero para el juego");
                generoJuego = Console.ReadLine();

                if (generoJuego.Length > 0)
                {
                    salir = true;
                    juegos.Add(new Juego(nombreJuego, precioJuego, generoJuego));
                }
                else
                {
                    Console.WriteLine("Error ! La cadena no puede estar vacia");
                }

            } while (!salir);
            return juegos;
        }

        
        public static void MostrarLosJuegos(List<Juego> juegos)
        {
            // Declaramos las variables
            Console.WriteLine("Lista de juegos: ");

            foreach (Juego juego in juegos)
            {
                Console.WriteLine(juego.GetNombre());
                Console.WriteLine(juego.GetPrecio());
                Console.WriteLine(juego.GetGenero());
                Console.WriteLine("---------------------------");

            }
            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();

               
        }
    }
}
