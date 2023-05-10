namespace ejer2
{
    internal class Pedido
    {
        // Atributos
        private List<Producto> productosAñadidos { get; set; }
        private DateTime Fecha { get; set; }

        // Constructor
        public Pedido(List<Producto> productos, DateTime Fecha)
        {
            SetProductos(productos);
            SetFecha(Fecha);
        }
        // Metodos

        public const int NUMERO_MAXIMO_PEDIDO = 5;
        public List<Producto> GetProductos()
        {
            return this.productosAñadidos;
        }

        public int GetNUMERO_MAXIMO_PEDIDOS()
        {
            return NUMERO_MAXIMO_PEDIDO;
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
                this.Fecha = new DateTime(2022, 1, 1);
            }
        }
        public DateTime GetFecha()
        {
            return this.Fecha;
        }

        public string ToString()
        {
            string pedido = "";
            pedido = "productos" + this.productosAñadidos.ToString() + "\n a la fecha de: " + this.Fecha
                ;

            return pedido;
        }

        public static void MostrarPedidoAcabadoDeIntroducir(List<Pedido> pedidos)
        {
            Console.WriteLine($"Su pedido es: {pedidos[0].ToString()}");
        }


    }
}
