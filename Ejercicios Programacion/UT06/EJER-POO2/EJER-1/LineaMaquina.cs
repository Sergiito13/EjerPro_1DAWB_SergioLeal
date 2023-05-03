namespace ejer1
{
    class LineaMaquina
    {
        private int ID { get; set; }

        private Producto ProductoLinea { get; set; }

        private int Stock { get; set; }

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
