namespace ejerbiblioteca
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            bool salirMenu = false;
            Bibblioteca bibblioteca = new Bibblioteca("Mi biblioteca");
            List<Libro> libros = new List<Libro>();

            do
            {
                Funciones.MostrarMenu();
                int otp = Funciones.PedirNumeroOpcionMenu();

                switch (otp)
                {
                    case 1:
                        Console.WriteLine("Opción 1 seleccionada");
                        Console.ReadKey();
                        bool salirOpcion = false;
                        do
                        {
                            Console.WriteLine("Vamos añadir un libro");
                            string titulo = Libro.PedirTitulo();
                            string autor = Libro.PedirAutor();
                            int nPaginas = Libro.PedirNPaginas();
                            Libro miLibro = new Libro(titulo, autor, nPaginas);

                            libros.Add(miLibro);

                            bibblioteca.AgregarLibro(miLibro);

                            Console.WriteLine("Se ha añadido correctament los libros");

                            if (!Funciones.PedirRespuestaSeguir())
                                salirOpcion = true;

                        } while (!salirOpcion);

                        break;
                    case 2:
                        Console.WriteLine("Opción 2 seleccionada");
                        Console.ReadKey();

                        salirOpcion = false;
                        do
                        {
                            Funciones.MostrarOpcionesBuscar();
                            int opcion = Funciones.PedirNumeroOpcionMenu();

                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("Opción 1 seleccionada");
                                    Console.ReadKey();

                                    break;
                                case 2:
                                    Console.WriteLine("Opción 2 seleccionada");
                                    Console.ReadKey();

                                    break;
                                default:
                                    Console.WriteLine("Opción no válida.");
                                    break;
                            }
                        } while (!salirOpcion);
                        break;
                    case 3:
                        Console.WriteLine("Opción 3 seleccionada");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Opción 4 seleccionada");
                        salirMenu = true;
                        Console.WriteLine(bibblioteca.ToString());
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        salirMenu = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intentelo de nuevo");
                        Console.ReadKey();
                        break;
                }

            } while (!salirMenu);


        }


    }
}