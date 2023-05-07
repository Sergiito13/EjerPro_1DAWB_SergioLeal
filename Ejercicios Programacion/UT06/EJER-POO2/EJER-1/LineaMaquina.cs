namespace ejer1
{
    class LineaMaquina
    {
        private int IDLinea { get; set; }

        private Producto ProductoLinea { get; set; }

        private int Stock { get; set; }

        // CONSTRUCTORES

        public LineaMaquina(Producto productoLinea, int stock)
        {
            this.IDLinea = Funciones.GenerateIdLinea();
            SetProductoLinea(productoLinea);
            SetStock(stock);

        }
        // METODOS
        public void SetIDLinea(int Id)
        {
            IDLinea = Id;
        }

        public void SetProductoLinea(Producto nombrePro)
        {
            if (nombrePro != null)
            {
                ProductoLinea = nombrePro;
            }
            else
            {
                ProductoLinea = null;
            }

        }

        public void SetStock(int stock)
        {
            if (stock > 0 && stock <= 10)
            {
                Stock = stock;
            }
            else
            {
                Stock = 0;
            }

        }

        public int GetID()
        {
            return this.IDLinea;
        }
        public Producto GetProductoLinea()
        {
            return this.ProductoLinea;
        }
        public int Getstock()
        {
            return this.Stock;
        }

        public string ToString()
        {
            string producto = "";
            producto = "ID de la linea de máquina: " + this.IDLinea + "\tproducto: " + ProductoLinea.ToString() + "\tstock: " + this.Stock;

            return producto;
        }
    }
}
