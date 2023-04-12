namespace ejer1
{
    class Genero
    {
        // Atributos
        private string nombre { get; set; }

        // Constructores
        public Genero(string nombre)
        {
            this.nombre = nombre;
        }
        // Métodos
        public string ToString()
        {
            string juegoInfo = "";
            juegoInfo = this.nombre;

            return juegoInfo;
        }
    }
}
