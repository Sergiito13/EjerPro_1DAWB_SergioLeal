using System;
using static biblio.Libro;

namespace biblio
{
    class Program
    {
        public void Main(string[] args)
        {
            // Creamos el objeto Biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Crear libros
            Libro libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez", "9780307474728", GENERO.Novela, 399);
            Libro libro2 = new Libro("1984", "George Orwell", "9780451524935", GENERO.Cienciaficción,523);
            Libro libro3 = new Libro("El Principito", "Antoine de Saint-Exupéry", "9780156012195", GENERO.Literaturainfantil,255);

            // Agregar libros a la biblioteca
            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);

            // Crear usuarios
            Usuario usuario1 = new Usuario("Juan Pérez");
            Usuario usuario2 = new Usuario("María García");
            Usuario usuario3 = new Usuario("David González");

            // Agregar usuarios a la biblioteca
            biblioteca.AgregarUsuario(usuario1);
            biblioteca.AgregarUsuario(usuario2);
            biblioteca.AgregarUsuario(usuario3);

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("----- MENÚ -----");
                Console.WriteLine("1. Mostrar libros disponibles");
                Console.WriteLine("2. Mostrar usuarios");
                Console.WriteLine("3. Prestar libro");
                Console.WriteLine("4. Devolver libro");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        {

                        }
                        break;

                    case 2:
                        {

                        }
                        break;

                    case 3:
                        {

                        }
                        break;

                    case 4:
                        {

                        }
                        break ;
                    case 5:
                        // Salir
                        salir = true;
                        Console.WriteLine("¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;

                }
            }
        }
    }
}
