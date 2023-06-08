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
            HistoricoJuegos = new List<Juego>();
        }
        public Tienda(string encargado, string telefono)
        {
            setEncargado(encargado);
            SetTelefono(telefono);
            juegosAlquilados = new List<Juego>();
            juegosAlquilados = new List<Juego>();
            HistoricoJuegos = new List<Juego>();
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

        public void AñadirJuegosAlquilados(Juego juego)
        {
            juegosAlquilados.Add(juego);
        }
        public void AñadirJuegosDisponible(Juego juego)
        {
            juegosDisponibles.Add(juego);
        }

        public void DevolverJuego(Juego juego)
        {
            juegosAlquilados.Remove(juego);
        }
        public void AñadirJuegosHistorico(Juego juego)
        {
            HistoricoJuegos.Add(juego);
        }
        public void AñadirTodosLosJuegosdisponibles(List<Juego> juegos)
        {
            this.juegosDisponibles = juegos;
        }
        public Juego obtenereljuegoElegido(int eleccion)
        {
            return juegosDisponibles[eleccion];
        }

        public void AlquilarJuegoDisponible(Juego juego)
        {
            juegosDisponibles.Remove(juego);
        }

        public string MostrarJuegosDisponibles()
        {
            int contador = 0;
            string juegosDisponibles1 = "JUEGOS DISPONIBLES: \n";
            this.juegosDisponibles.ForEach(juegodisponible => juegosDisponibles1 += $"{contador++}.- {juegodisponible.ToString()}\n");
            return juegosDisponibles1;
        }

        public string DevolverCodigo()
        {
            string resultadoJuegosAlquilados = "LOS USUARIOS QUE TIENEN LIBRO ALQUILADOS SON: \n";

            this.juegosAlquilados.ForEach(codigoUsu => resultadoJuegosAlquilados += $"Codigo: {codigoUsu.GetCode()}\n");
            return resultadoJuegosAlquilados;
        }

        public Juego ComprobarCodigoLibro(int codigo)
        {
            Juego JuegoSeleccionado = juegosAlquilados.Find(juego => juego.GetCode() == codigo);
            return JuegoSeleccionado;
        }

        public static int PedirNumeroJuegoDisponible()
        {
            int EleccionJuegoDisponible = 0;
            Console.WriteLine("");
            Console.WriteLine("Elige el juego que quieras alquilar:");
            while (!(int.TryParse(Console.ReadLine(), out EleccionJuegoDisponible) && (EleccionJuegoDisponible >= 0)))
            {
                Console.WriteLine("Error! Intentelo de nuevo");
            }
            return EleccionJuegoDisponible;
        }
        public bool EleccionExiste(int eleccionUsu)
        {
            bool eleccionCorrecta = false;

            if ((eleccionUsu >= 0) && (eleccionUsu <= this.juegosDisponibles.Count - 1))
                eleccionCorrecta = true;

            return eleccionCorrecta;
        }
        public bool BuscarSiExisteCoigoUsuario(int codUsu)
        {
            bool CodExiste = false;
            this.juegosAlquilados.ForEach(juegoAlquilado =>
            {
                if (codUsu == juegoAlquilado.GetCode())
                {
                    CodExiste = true;
                }
            });
            return CodExiste;
        }

        public string MostrarHistorico()
        {
            string Historcio = "HISTORICO DE ALQUILERES: \n";
            this.HistoricoJuegos.ForEach(juegohistorico => Historcio += $"{juegohistorico.ToString()}\n");
            return Historcio;
        }
    }
}
