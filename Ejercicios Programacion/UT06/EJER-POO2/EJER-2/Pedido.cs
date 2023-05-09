namespace ejer2
{
    internal class Pedido
    {
        // Atributos
        private const int NUMERO_MAXIMO_PEDIDO = 5;
        private List<Producto> productosAñadidos { get; set; }
        private DateTime Fecha { get; set; }

        // Constructor
        public Pedido(List<Producto> productos, DateTime Fecha)
        {
            SetProductos(productos);
            SetFecha(Fecha);
        }
        // Metodos

        public List<Producto> GetProductos()
        {
            return this.productosAñadidos;
        }

        public void SetProductos(List<Producto> productos)
        {
            if (productos.Count <= 0)
            {
                this.productosAñadidos = null;
            }
            else
            {
                this.productosAñadidos = productos;
            }

        }

        public void SetFecha(DateTime Fecha)
        {
            DateTime Fechahoy = DateTime.Now;

            if (Fecha == Fechahoy)
            {
                this.Fecha = Fecha;
            }
            else
            {
                this.Fecha = new DateTime(0000, 00, 00);
            }
        }
        public DateTime GetFecha()
        {
            return this.Fecha;
        }




    }
}
