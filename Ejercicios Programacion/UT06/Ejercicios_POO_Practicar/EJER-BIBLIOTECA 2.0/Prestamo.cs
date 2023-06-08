namespace biblio
{
    internal class Prestamo
    {
        // ATRIBUTOS
        private DateTime FechaPrestamo { get; set; }
        private DateTime FechaDevolucíon { get; set; }
        private Libro LibroPrestado { get; set; }
        private Usuario usuario { get; set; }

        // Constructores
        public Prestamo(DateTime FechaInicial, DateTime FechaDevolucion, Libro Libroprestado, Usuario UsuarioPrestamo)
        {

        }

    }
}
