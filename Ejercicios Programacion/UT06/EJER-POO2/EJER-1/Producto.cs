namespace ejer1
{
    class Producto
    {
        // ATRIBUTOS

        private int IDProducto { get; set; }
        private string nombreProducto { get; set; }

        private decimal precioProducto { get; set; }


        // CONSTRUCTORES

        public Producto(int ID, string nombreProducto, decimal precioProducto)
        {
            this.IDProducto = ID;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            
        }
        // METODOS
        public void SetID(int Id)
        {
            IDProducto = Id;
        }

        public void SetNombreProducto(string nombrePro)
        {
            if (string.IsNullOrEmpty(nombrePro))
            {
                nombreProducto = nombrePro;
            }
            else
            {
                nombreProducto = "";
            }

        }

        public void SetPrecioProducto(decimal precioPro)
        {
            precioProducto = precioPro;
        }

        public int GetID()
        {
            return this.IDProducto;
        }
        public string Getnombre()
        {
            return this.nombreProducto;
        }
        public decimal Getprecio()
        {
            return this.precioProducto;
        }

        public string ToString()
        {
            string producto = "";
            producto = "ID: " + this.IDProducto + "\tNombre: " + this.nombreProducto + "\tprecio: " + this.precioProducto + "\tStock: " + this.stockProducto;

            return producto;
        }
    }
}
