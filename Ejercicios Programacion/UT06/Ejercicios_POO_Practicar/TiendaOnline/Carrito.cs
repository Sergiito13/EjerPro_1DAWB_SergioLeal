namespace tiendaonline
{
    internal class Carrito
    {
        // ATRIBUTOS
        private Cliente cliente { get; set; }
        private List<Producto> productos { get; set; }
        private DateTime FechaCompra { get; set; }

        // CONSTRUCTORES
        public Carrito()
        {
            this.productos = new List<Producto>();
        }
        public Carrito(Cliente cliente, List<Producto> productos, DateTime fechaCompra)
        {
            this.cliente = cliente;
            this.productos = productos;
            FechaCompra = fechaCompra;
        }


        // GETTERS Y SETTERS
        // METODOS
        public override string ToString()
        {
            string linea = "Carrito:\n";
            linea += $"Cliente: {this.cliente.ToString()}\n";
            linea += $"Productos: ";
            productos.ForEach(producto => linea += $"{producto.ToString()}");
            linea += $"Fecha Compra: {this.FechaCompra}\n";

            return linea;
        }
    }
}
