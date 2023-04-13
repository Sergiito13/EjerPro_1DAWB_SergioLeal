using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Productos
    {
        // ATRIBUTOS

        private int IDProducto { get; set; }
        private string nombreProducto { get; set; }

        private decimal precioProducto { get; set; }

        private int stockProducto { get; set; }

        // CONSTRUCTORES

        public Productos(int ID, string nombreProducto, decimal precioProducto, int stockProducto)
        {
            this.IDProducto = ID;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
        }
        // METODOS

        public int GetID()
        {
            return this.IDProducto;
        }

        public string ToString()
        {
            string producto = "";
            producto = "ID: " + this.IDProducto + "\tNombre: " + this.nombreProducto + "\tprecio: " + this.precioProducto + "\tStock: " + this.stockProducto;

            return producto;
        }
    }
}
