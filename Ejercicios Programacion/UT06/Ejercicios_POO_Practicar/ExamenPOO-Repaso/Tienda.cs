using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examentienda
{
    internal class Tienda
    {
        // ATRIBUTOS
        private string encargado { get; set; }
        private string telefono { get; set; }
        private List<Juego> juegosDisponibles { get; set; }

        private List<Juego> juegosAlquilados { get; set; }

        private List<Juego> HistoricoJuegos { get; set; }

        // CONSTRUCTORES
        public Tienda()
        {
            juegosAlquilados = new List<Juego>();
            juegosAlquilados = new List<Juego>();
        }
        public Tienda(string encargado, string telefono)
        {
            setEncargado(encargado);
            SetTelefono(telefono);
            juegosAlquilados= new List<Juego>();
            juegosAlquilados = new List<Juego>();
        }

        // GETTERS Y SETTERS
        public void setEncargado(string encargado)
        {
            if (!(string.IsNullOrEmpty(encargado) && encargado.Length < 3))
            {
                this.encargado = encargado;
            }
            else
            {
                this.encargado = "Error";
            }
        }

        public string GetEncargado()
        {
            return this.encargado;
        }

        public void SetTelefono(string telefono)
        {
            if (telefono.StartsWith("922"))
            {
                this.telefono = telefono;
            }
            else
            {
                this.telefono = "000000000";
            }

           

        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        // To string

        public override string ToString()
        {
            string linea = $"Encargado de tienda: {this.encargado}\n";
            linea += $"Telefono de tienda: {this.telefono}\n";
            linea += $"\n";
            linea += $"Juegos disponibles:\n";
            juegosDisponibles.ForEach(juego => linea += $"{juego}\n");
            linea += $"\n";
            linea += $"Juegos alquilados:\n";
            juegosAlquilados.ForEach(juego => linea += $"{juego}\n");
            return linea;
        }

        // METODOS
        public static string pedirNombreEncargado()
        {
            // Declaramos las variables
            string nombreEncargado = "";
            // Pedimos los datos
            Console.WriteLine("Dime el nombre del encargado");
            nombreEncargado = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(nombreEncargado) || (nombreEncargado.Length < 3))
            {
                Console.WriteLine("Error. Intentelo de nuevo");
                nombreEncargado = Console.ReadLine().Trim();
            }
            return nombreEncargado;
        }

        public static string pedirTelefonoEncargado()
        {
            // Declaramos las variables
            string telefonoEncargado = "";
            Console.WriteLine("Introduzca el telefono del encargado");
            telefonoEncargado = Console.ReadLine().Trim();

            while ((telefonoEncargado.Length != 9) || (!telefonoEncargado.StartsWith("922")))
            {
                Console.WriteLine("ERROR! Intentelo de nuevo");
                telefonoEncargado = Console.ReadLine().Trim();
            }
            return telefonoEncargado;
        }

        public void AñadirJuegosAlquilados(Juego juegos)
        {
            juegosAlquilados.Add(juegos);
        }
        public void AñadirTodosLosJuegosdisponibles(List<Juego> juegos)
        {
            this.juegosDisponibles = juegos;
        }
    }
}
