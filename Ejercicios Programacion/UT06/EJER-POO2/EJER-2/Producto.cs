namespace ejer2
{
    class Producto
    {
        // ATRIBUTOS

        private int ID { get; set; }
        private string nombreProducto { get; set; }

        private decimal precioProducto { get; set; }


        // CONSTRUCTORES

        public Producto(string nombreProducto, decimal precioProducto)
        {
            this.ID = GenerateId();
            SetNombreProducto(nombreProducto);
            SetPrecioProducto(precioProducto);

        }
        // METODOS
        public void SetID(int Id)
        {
            ID = Id;
        }

        public void SetNombreProducto(string nombrePro)
        {
            if (!string.IsNullOrEmpty(nombrePro))
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
            return this.ID;
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
            producto = "ID: " + this.ID + "\tNombre: " + this.nombreProducto + "\tprecio: " + this.precioProducto + " $";

            return producto;
        }

        // Metodos
        //Para aumentar el ID
        private static int IDAutoIncremental = 1;
        public int GenerateId()
        {
            return IDAutoIncremental++;
        }

        
    }
}
