using System;
namespace examentienda
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Pedir datos para el encargado 
            string nombreEncargado = Tienda.pedirNombreEncargado();
            string telefonoEncargado = Tienda.pedirTelefonoEncargado();
            Tienda tienda = new Tienda(nombreEncargado,telefonoEncargado);

            // Metemos todos los juegos
            List<Juego> juegos = new List<Juego>();
            juegos.Add(new Juego("Zelda", 35.70m,1));
            juegos.Add(new Juego("Mario", 30,1));
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
                                int codigo = Juego.PedirCodigoUsu();

                                /*if (!Juego.BuscarSiUsuario(juegos, codigo))
                                {
                                    int contador = 1;
                                    Console.WriteLine($"{contador++} {juegos.ToString()}");
                                }
                                else
                                {
                                    Console.WriteLine("Este usuario ya tiene alquilado un juego");
                                }*/
                            } while (!correcto);


                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Has elegido la opción 2");
                            Console.ReadKey();
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
