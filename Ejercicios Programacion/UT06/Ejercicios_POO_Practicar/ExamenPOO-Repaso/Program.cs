namespace examentienda
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Pedir datos para el encargado 
            string nombreEncargado = Tienda.pedirNombreEncargado();
            string telefonoEncargado = Tienda.pedirTelefonoEncargado();
            Tienda tienda = new Tienda(nombreEncargado, telefonoEncargado);

            // Metemos todos los juegos
            List<Juego> juegos = new List<Juego>();
            juegos.Add(new Juego("Zelda", 35.70m, 1));
            juegos.Add(new Juego("Mario", 30, 1));
            juegos.Add(new Juego("Sonic", 27.40m, 1));
            juegos.Add(new Juego("Alex Kid", 15.20m, 1));
            juegos.Add(new Juego("Wonder Boy", 21.90m, 1));

            //Añadimos todos los juegos que tenemos a la lista de juegos disponibles de la tienda
            tienda.AñadirTodosLosJuegosdisponibles(juegos);

            bool salir = false;
            do
            {
                Funciones.MostrarMenu();
                int opcion = Funciones.PedirOpcionesMenu();
                switch (opcion)
                {
                    case 1:
                        {
                            bool correcto = false;
                            do
                            {
                                Console.WriteLine("Has elegido la opción 1");
                                Console.ReadKey();
                                Console.WriteLine("");
                                bool codunico = false;
                                int codigoUsu = 0, eleccionUsu = 0;
                                do
                                {
                                    codigoUsu = Juego.PedirCodigoUsu();

                                    if (!tienda.BuscarSiExisteCoigoUsuario(codigoUsu))
                                        codunico = true;

                                } while (!codunico);

                                bool eleccionexiste = false;
                                do
                                {
                                    Console.WriteLine($"{tienda.MostrarJuegosDisponibles()}");
                                    eleccionUsu = Tienda.PedirNumeroJuegoDisponible();

                                    if (tienda.EleccionExiste(eleccionUsu))
                                        eleccionexiste = true;

                                } while (!eleccionexiste);

                                Juego juegoElegido = tienda.obtenereljuegoElegido(eleccionUsu);
                                juegoElegido.SetCode(codigoUsu);
                                tienda.AlquilarJuegoDisponible(juegoElegido);
                                tienda.AñadirJuegosAlquilados(juegoElegido);
                                Console.WriteLine("Se ha alquilado correctamente");
                                correcto = true;
                            } while (!correcto);


                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Has elegido la opción 2");
                            Console.ReadKey();
                            bool salir2 = false;

                            do
                            {
                                Console.WriteLine(tienda.DevolverCodigo());
                                int codigoUsu = Juego.PedirCodigoUsu();
                                Juego JuegoSeleccionado = tienda.ComprobarCodigoLibro(codigoUsu);

                                if (JuegoSeleccionado != null)
                                {
                                    tienda.DevolverJuego(JuegoSeleccionado);
                                    tienda.AñadirJuegosDisponible(JuegoSeleccionado);
                                    tienda.AñadirJuegosHistorico(JuegoSeleccionado);
                                    JuegoSeleccionado.CambiarCodigo0();
                                    salir2 = true;

                                }
                                else
                                {
                                    Console.WriteLine("El ID de usuario no es correcto");
                                }



                            } while (!salir2);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Has elegido la opción 3");
                            Console.ReadKey();
                            Console.WriteLine(tienda.ToString());
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Has elegido la opción 4");
                            Console.ReadKey();
                            Console.WriteLine($"{tienda.MostrarHistorico()}");
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine("Saliendo...");
                            Console.ReadKey();
                            salir = true;

                        }

                        break;
                    default:
                        {
                            Console.WriteLine("Opcion no válida");
                        }
                        break;
                }
            } while (!salir);

        }
    }
}
