namespace tiendaonline
{
    internal class Producto
    {
        // ATRIBUTOS
        private int ID { get; set; }
        private string Nombre { get; set; }
        private decimal Precio { get; set; }
        private int stock { get; set; }

        // CONSTRUCTORES
        public Producto()
        {

        }
        public Producto(string nombre, decimal precio, int stock)
        {
            ID = GenerateId();
            SetNombre(nombre);
            SetPrecio(precio);
            SetStock(stock);
        }

        // GETTERS Y SETTERS
        public int GetID()
        {
            return this.ID;
        }
        public string GetNombre()
        {
            return this.Nombre;
        }
        public decimal GetPrecio()
        {
            return this.Precio;
        }
        public int Getstock()
        {
            return this.stock;
        }
        //-------------------------------------
        public void SetID(int ID)
        {
            if (ID <= 0)
            {
                this.ID = 0;
            }
            else
            {
                this.ID = ID;
            }
        }
        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.Nombre = nombre;
            }
            else
            {
                this.Nombre = "";
            }
        }

        public void SetPrecio(decimal precio)
        {
            if (!(precio < 0))
            {
                this.Precio = precio;
            }
            else
            {
                this.Precio = 9999999999999;
            }
        }
        public void SetStock(int Stock)
        {
            if (Stock <= 0)
            {
                this.stock = 0;
            }
            else
            {
                this.stock = Stock;
            }
        }


        // METODOS
        private static int IDAutoIncremental = 1;
        public int GenerateId()
        {
            return IDAutoIncremental++;
        }
        public override string ToString()
        {
            string linea = "Productos:\n";
            linea += $"ID: {this.ID}\n";
            linea += $"Nombre: {this.Nombre}\n";
            linea += $"Precio: {this.Precio}\n";
            linea += $"Stock: {this.stock}\n";

            return linea;
        }
    }
}
