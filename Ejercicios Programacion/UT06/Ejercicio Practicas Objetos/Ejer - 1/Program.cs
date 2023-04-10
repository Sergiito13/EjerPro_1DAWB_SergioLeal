namespace ejer1
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            List<Juego> juegos = new List<Juego>();
            int opcion;
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------Menu--------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("- 1.- Añadir Juego                      -");
                Console.WriteLine("- 2.- Mostrar Lista de juegos           -");
                Console.WriteLine("- 3.- Salir                             -");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Dime una opcion del menu");
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("ERROR !");
                }
                if ((opcion >= 1) || (opcion <= 2))
                {
                    switch (opcion)
                    {
                        case 1:
                            {
                                //pedir  nombre del juego
                                //Pedir precio del juego
                                //Pediro género del juego
                                //Crear nueva instancia del juego (llamar a su constructor) con los datos recogidos
                                //Añadir el nuevo juego craedo a la lista de juegos

                                bool control = false;
                                string nombreJuego = "", nombre = "";
                                decimal precioJuego = 0;

                                do
                                {
                                    Console.WriteLine("Dime un nombre de un juego");
                                    nombreJuego = Console.ReadLine();

                                    if (nombreJuego.Length > 0)
                                    {
                                        control = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error! La cadena no puede estar vacia");
                                    }
                                } while (!control);

                                salir = false;

                                do
                                {
                                    Console.WriteLine("Dime un precio para el juego nuevo");
                                    while (!decimal.TryParse(Console.ReadLine(), out precioJuego))
                                    {
                                        Console.WriteLine("Error ! Tiene que ser de tipo decimal el dato");
                                    }
                                    if (precioJuego >= 0)
                                    {
                                        control = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error ! El precio no puede ser negativo");
                                    }

                                } while (!control);

                                control = false;
                                Genero generoJuego;
                                do
                                {
                                    Console.WriteLine("Dime un genero para el juego");
                                    nombre = Console.ReadLine();

                                    if (nombre.Length > 0)
                                    {
                                        control = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error ! La cadena no puede estar vacia");
                                    }

                                } while (!control);

                                generoJuego = new Genero(nombre);
                                Juego juegoAux = new Juego(nombreJuego, precioJuego, generoJuego);
                                juegoAux.ToString();
                                juegos.Add(juegoAux);

                                //juegos.Add(new Juego("Zelda", 55m, "Aventuras"));
                                
                            }
                            ; break;
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("| LISTA DE JUEGOS: ");
                                Console.WriteLine("---------------------------");

                                foreach (Juego juego in juegos)
                                {
                                    Console.WriteLine(juego.ToString());
                                    

                                }
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Pulsa una tecla para continuar.");
                                Console.ReadKey();
                            }
                            ; break;
                        case 3:
                            salir = true;
                            break;
                    }
                }
            } while (!salir);


        }
    }
}
