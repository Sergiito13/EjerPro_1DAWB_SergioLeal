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

        public static void MostrarProductos(List<Producto> productos)
        {
            productos.ForEach(producto => Console.WriteLine(producto.ToString()));
            Console.ReadKey();
        }

        public static int PedirIdProducto() // Esta funcion pedira un id al usuario
        {
            int idSeleccionado = 0;

            Console.WriteLine("Dime el ID del producto que quieres pedir:");
            while (!int.TryParse(Console.ReadLine(), out idSeleccionado) || (idSeleccionado <= 0))
            {
                Console.WriteLine("No es valido el valor introducido. Intentelo De nuevo");
            }
            return idSeleccionado;
        }

        // Preguntar al profe porque esta funcion no va si no es estatica
        public static Producto ComprobarIDExiste(List<Producto> productos, int idSeleccionado)// Esta funcion comprobara que el id pasado se corresponde con uno existente
        {
            Producto productoelegido = productos.Find(Producto => Producto.GetID() == idSeleccionado);

            return productoelegido;
        }
    }
}
