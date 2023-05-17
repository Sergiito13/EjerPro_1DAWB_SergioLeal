using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio
{
    internal class Usuario
    {
        // ATRIBUTOS
        private int ID { get; set; }
        private string Nombre { get; set; }
        private List<Prestamo> Prestamos { get; set; }

        // Constructores
        public Usuario(string nombre)
        {
            this.ID = GenerateId();
            SetNombre(nombre);
            this.Prestamos = new List<Prestamo>();
        }
        
        // GETTERS Y SETTERS
        public void SetID(int id)
        {
            if (!(id <= 0))
            {
                this.ID = id;
            }
            else
            {
                this.ID = 0;
            }
            
        }

        public int GetID()
        {
            return this.ID;
        }
        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.Nombre = nombre;
            }
            else
            {
                this.Nombre = "Error";
            }
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public void SetPrestamos(List<Prestamo> prestamos)
        {
            if (!(prestamos == null))
            {
                this.Prestamos = prestamos;
            }
            else
            {
                this.Prestamos = new List<Prestamo>();
            }

        }

        public List<Prestamo> GetPrestamos()
        {
            return this.Prestamos;
     
        }

        // METODOS
        private static int IDAutoIncremental = 1;
        public int GenerateId()
        {
            return IDAutoIncremental++;
        }
    }
}
