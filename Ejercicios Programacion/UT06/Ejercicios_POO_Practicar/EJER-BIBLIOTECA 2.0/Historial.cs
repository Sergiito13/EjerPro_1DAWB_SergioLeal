using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio
{
    internal class Historial
    {
        // ATRIBUTOS
        private List<Prestamo> HistoricoPrestamos { get; set; }
    
        // CONSTRUCTOR
        public Historial()
        {
            HistoricoPrestamos = new List<Prestamo>();
        }

        // GETTERS Y SETTERS
        public List<Prestamo> GetHistorico()
        {
            return HistoricoPrestamos;
        }
        public void SetHistorico(List<Prestamo> historico)
        {
            if (!(historico == null))
            {
                this.HistoricoPrestamos = historico;
            }
            else
            {
                this.HistoricoPrestamos = new List<Prestamo>();
            }
        }
    }
    
}
