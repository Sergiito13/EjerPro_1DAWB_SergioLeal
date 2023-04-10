namespace ejer1
{
    class Juego
    {
        // Atributos
        private string nombre { get; set; }
        private decimal precio { get; set; }
        private Genero genero { get; set; }

        // Constructores

        public Juego(string nombre, decimal precio, Genero genero)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
        }

        // Metodos

        public string ToString()
        {
            string juegoInfo = "";
            juegoInfo = "Nombre: "+this.nombre + "\tPrecio: " + this.precio + "\tGenero: " + this.genero.nombre;

            return juegoInfo;
        }



    }
}
