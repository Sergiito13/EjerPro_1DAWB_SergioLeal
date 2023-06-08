namespace ejerbiblioteca
{
    internal class Libro
    {
        // ATRIBUTOS
        private int ID { get; set; }
        private string titulo { get; set; }

        private string autor { get; set; }

        private int numeroPaginas { get; set; }

        // CONSTRUCTOR

        public Libro(string titulo, string autor, int numeroPaginas)
        {
            this.ID = GenerateId();
            SetTitulo(titulo);
            SetAutor(autor);
            SetNumeroPagina(numeroPaginas);
        }

        public void SetID(int Id)
        {
            ID = Id;
        }

        public int GetID()
        {
            return this.ID;
        }

        public void SetTitulo(string titulo)
        {
            if (!string.IsNullOrEmpty(titulo))
            {
                this.titulo = titulo;
            }
            else
            {
                this.titulo = "Ha ocurrido un error";
            }
        }

        public string GetTitulo()
        {
            return this.titulo;
        }

        public void SetAutor(string autor)
        {
            if (!string.IsNullOrEmpty(autor))
            {
                this.autor = autor;
            }
            else
            {
                this.autor = "Ha ocurrido un error";
            }
        }

        public string GetAutor()
        {
            return this.autor;
        }

        public void SetNumeroPagina(int numeroPaginas)
        {
            if (!(numeroPaginas <= 0))
            {
                this.numeroPaginas = numeroPaginas;
            }
            else
            {
                this.numeroPaginas = 0;
            }
        }

        public int GetNumeroPagina()
        {
            return this.numeroPaginas;
        }

        public override string ToString()
        {
            string linea = $"";
            linea += $"ID: {this.ID}\n";
            linea += $"Titulo: {this.titulo}\n";
            linea += $"Autor: {this.autor}\n";
            linea += $"Nº pagina: {this.numeroPaginas}\n";
            linea += $"";

            return linea;
        }

        private static int IDAutoIncremental = 1;
        public int GenerateId()
        {
            return IDAutoIncremental++;
        }

        public static string PedirTitulo()
        {
            string titulo = "";
            Console.WriteLine("Introduce el nombre del titulo del libro");
            titulo = Console.ReadLine();
            while (string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("El autor no puede ser nulo o vacío");
                titulo = Console.ReadLine();
            }
            return titulo;
        }

        public static string PedirAutor()
        {
            string autor = "";
            Console.WriteLine("Introduce el nombre del autor del libro");
            autor = Console.ReadLine();
            while (string.IsNullOrEmpty(autor))
            {
                Console.WriteLine("El autor no puede ser nulo o vacío");
                autor = Console.ReadLine();
            }
            return autor;
        }

        public static int PedirNPaginas()
        {
            int nPaginas = 0;
            Console.WriteLine("Introduce el número de páginas del libro");
            while (!int.TryParse(Console.ReadLine(), out nPaginas) || (nPaginas < 0))
            {
                Console.WriteLine("El número de páginas no es válido");
            }
            return nPaginas;
        }
    }
}
