using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    class Productos
    {
        // Atributos
        
        private int ID { get; set; }
        private string nombreProducto { get; set; }

        private decimal precioProducto { get; set; }


        // Constructores
        public Productos(int ID, string nombre, decimal precio)
        {
            this.ID = ID;
            this.nombreProducto = nombre;
            this.precioProducto = precio;
        }

        // Metodos

        public void SetID(int ID)
        {
            if (ID < 0)
            {
                ID = 0;
            }
            else
            {
                ID = ID;
            }
        }

        public void SetNombreProducto(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                nombreProducto = nombre;
            }
            else
            {
                nombreProducto = "Algo ha salido mal";
            }
            
        }

        public void SetPrecioProducto(decimal precio)
        {
            if (precio < 0)
            {
                precioProducto = 0;
            }
            else
            {
                precioProducto = precio;
            }
            
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
            producto = "ID: " + this.ID + "\tNombre: " + this.nombreProducto + "\tprecio: " + this.precioProducto;

            return producto;
        }

    }

        

        
}
