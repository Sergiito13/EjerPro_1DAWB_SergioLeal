namespace ejer2
{
    internal class Cafeteria
    {
        // Atributos
        private string nombre { get; set; }

        private List<Pedido> pedidosRealizados { get; set; }

        // Constructores

        public Cafeteria(string nombre, List<Pedido> pedidosRealizados)
        {

        }

        public void Setnombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
            else
            {
                this.nombre = "Ha ocurrido un error";
            }
        }

        public string Getnombre()
        {
            return nombre;
        }

        public void SetpedidosRealizados(List<Pedido> pedidosRealizados)
        {
            this.pedidosRealizados = pedidosRealizados;
        }

        public List<Pedido> GetPedidosRealizados()
        {
            return pedidosRealizados;
        }

        // Metodos

    }
}
