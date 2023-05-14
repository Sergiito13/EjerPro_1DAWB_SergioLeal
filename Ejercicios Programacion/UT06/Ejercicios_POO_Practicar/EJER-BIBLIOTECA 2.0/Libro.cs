using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio
{
    internal class Libro
    {
        // ATRIBUTOS
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string ISBN { get; set; }
        private GENERO Genero { get; set; }
        private int NumeroPaginas { get; set; }
        private List<Prestamo> CantidadPrestamos {get; set;}

        // CONSTRUCTORES

        // METODOS
        
         
        public enum GENERO
        {
            Novela,
            Aventura,
            Ciencia ficción,
            Fantasía,
            Romance,
            Suspenso,
            Policíaco,
            Histórico,
            Biografía,
            Ensayo,
            Autoayuda,
            Cocina,
            Viajes,
            Arte,
            Literatura infantil,
            Literatura juvenil,
            Cómic,
            Manga,
            Poesía,
            Drama,
        }

    }
}
