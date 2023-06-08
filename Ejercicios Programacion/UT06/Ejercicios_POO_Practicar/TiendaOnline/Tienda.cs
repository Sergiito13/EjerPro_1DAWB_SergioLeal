namespace tiendaonline
{
    internal class Tienda
    {
        // ATRIBUTOS
        private string Nombre { get; set; }
        private List<Carrito> historico { get; set; }

        // CONSTRUCTORES
        public Tienda()
        {
            historico = new List<Carrito>();
        }
        public Tienda(string nombre, List<Carrito> historico)
        {
            Nombre = nombre;
            this.historico = historico;
        }
        // GETTERS Y SETTERS
        // METODOS
    }
}
