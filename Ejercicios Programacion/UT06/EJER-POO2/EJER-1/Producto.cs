using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class Producto
    {
        // ATRIBUTOS

        private int IDProducto { get; set; }
        private string nombreProducto { get; set; }

        private decimal precioProducto { get; set; }

        private int stockProducto { get; set; }

        private 

        // CONSTRUCTORES

        public Producto(int ID, string nombreProducto, decimal precioProducto, int stockProducto)
        {
            this.IDProducto = ID;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
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

        public void SetStockProducto(int stock) 
        {
            if ((stock < 0) || (stock > 10))
            {
                stockProducto = 0;
            }
            else
            {
                stockProducto = stock;
            }
            
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
        public int GetStock()
        {
            return this.stockProducto;
        }


        public string ToString()
        {
            string producto = "";
            producto = "ID: " + this.IDProducto + "\tNombre: " + this.nombreProducto + "\tprecio: " + this.precioProducto + "\tStock: " + this.stockProducto;

            return producto;
        }
    }
}
