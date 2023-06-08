namespace biblio
{
    internal class Libro
    {
        // ATRIBUTOS
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string ISBN { get; set; }
        private GENERO Genero { get; set; }
        private int NumeroPaginas { get; set; }
        private List<Prestamo> CantidadPrestamos { get; set; }

        // CONSTRUCTORES
        public Libro()
        {
            CantidadPrestamos = new List<Prestamo>();
        }
        public Libro(string Titulo, string Autor, string ISBN, GENERO Genero, int numeroPaginas)
        {
            SetTitulo(Titulo);
            SetAutor(Autor);
            CantidadPrestamos = new List<Prestamo>();
        }
        // SETERS Y GETTERS
        public void SetTitulo(string titulo)
        {
            if (!string.IsNullOrEmpty(titulo))
            {
                this.Titulo = titulo;
            }
            else
            {
                this.Titulo = "Error";
            }
        }

        public string GetTitulo()
        {
            return this.Titulo;
        }

        public void SetAutor(string autor)
        {
            if (!string.IsNullOrEmpty(autor))
            {
                this.Autor = autor;
            }
            else
            {
                this.Autor = "Error";
            }
        }

        public string GetAutor()
        {
            return this.Autor;
        }

        public void SetISBN(string ISBN)
        {
            if (!string.IsNullOrEmpty(ISBN))
            {
                this.ISBN = ISBN;
            }
            else
            {
                this.ISBN = "Error";
            }
        }

        public string GetISBN()
        {
            return this.ISBN;
        }
        public void SetGenero(GENERO Genero)
        {
            if (!(Genero == null))
            {
                this.Genero = Genero;
            }

        }

        public GENERO GetGenero()
        {
            return this.Genero;
        }

        public void SetNPaginas(int NPaginas)
        {
            if (NPaginas > 0)
            {
                this.NumeroPaginas = NPaginas;
            }
            else
            {
                this.NumeroPaginas = 0;
            }

        }

        public int GetNPaginas()
        {
            return this.NumeroPaginas;
        }

        public void SetNCantidadPrestamos(List<Prestamo> cantidadPrestamos)
        {
            if (!(cantidadPrestamos == null))
            {
                this.CantidadPrestamos = CantidadPrestamos;
            }
            else
            {
                this.CantidadPrestamos = new List<Prestamo>();
            }

        }

        public List<Prestamo> GetCantidadPrestamos()
        {
            return this.CantidadPrestamos;
        }

        // METODOS
        public enum GENERO
        {
            Novela,
            Aventura,
            Cienciaficción,
            Fantasía,
            Romance,
            Suspenso,
            Policíaco,
            Histórico,
            Biografía,
            Ensayo,
            Autoayuda,
            Cocina,
            Viajes,
            Arte,
            Literaturainfantil,
            Literaturajuvenil,
            Cómic,
            Manga,
            Poesía,
            Drama,
        }

    }
}
