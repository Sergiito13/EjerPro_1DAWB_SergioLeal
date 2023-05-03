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
            SetProducto(productoLinea);
            SetPrecioProducto(stock);

        }
        // METODOS
        public void SetIDLinea(int Id)
        {
            IDLinea = Id;
        }

        public void SetProducto(Producto nombrePro)
        {
            if (nombrePro != null)
            {
                ProductoLinea = nombrePro;
            }
            else
            {
                
            }

        }

        public void SetPrecioProducto(int stock)
        {
            if (stock > 0 && stock <= 10)
            {
                stock = stock;
            }
            else
            {
                stock= 0;
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
            producto = "ID de la linea de máquina: " + this.IDLinea + "\tproducto: " + this.ProductoLinea + "\tstock: " + this.Stock;

            return producto;
        }




















        //Constructor
        public LineaMaquina(Producto productoLinea, int Stock)
        {
            // LLAMAR SETERS
        }



        public static void AsignarProductoLinea()
        {
            string nombreProducto = "";
            int stock = 0;
            decimal precio = 0;
            List<LineaMaquina> listaLineasMaquina = new List<LineaMaquina>();



            Console.WriteLine("Dime el nombre del producto que quieres meter");

            // Crear FOREACH para mostrar lista productos

            nombreProducto = Console.ReadLine();

            Console.WriteLine("Dime el stock de el producto ");
            stock = Convert.ToInt32(Console.ReadLine());

            // Comprobar que el stock sea menor o igual a 10



        }
    }
}
