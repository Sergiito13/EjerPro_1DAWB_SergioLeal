namespace ejerbiblioteca
{
    internal class Bibblioteca
    {
        // ATRIBUTOS
        private string nombre { get; set; }
        private List<Libro> CatalogoLibros { get; set; }

        // CONSTRUCTOR
        public Bibblioteca(string nombre)
        {
            CatalogoLibros = new List<Libro>();
            this.nombre = nombre;
        }

        // Metodos

        public void SetCatalogoLibros(List<Libro> CatalogoLibros)
        {
            if (!(CatalogoLibros == null))
            {
                this.CatalogoLibros = CatalogoLibros;
            }
            else
            {
                CatalogoLibros = new List<Libro>();
            }
        }

        public void AgregarLibro(Libro libro)
        {
            this.CatalogoLibros.Add(libro);
        }

        public override string ToString()
        {
            string linea = $"El nombre de la biblioteca es: {nombre}\n";
            linea += $"Los libros que tiene son:\n";
            this.CatalogoLibros.ForEach(libro => linea += $"libro: {libro}\n");

            return linea;
        }
    }
}
