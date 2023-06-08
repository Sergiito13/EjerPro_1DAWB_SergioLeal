namespace biblio
{
    internal class Biblioteca
    {
        // ATRIBUTOS
        private List<Usuario> usuarios { get; set; }

        private List<Libro> Libros { get; set; }

        // CONSTRUCTORES
        public Biblioteca()
        {
            this.usuarios = new List<Usuario>();
            this.Libros = new List<Libro>();
        }
        // GETTERS Y SETTERS


        public void AgregarLibro(Libro libro)
        {
            this.Libros.Add(libro);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            this.usuarios.Add(usuario);
        }
    }
}
