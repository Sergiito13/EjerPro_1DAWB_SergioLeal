namespace Juego_Pokemon
{
    internal class Movimiento
    {
        // ATRIBUTOS
        private string nombre { get; set; }
        private List<string> tipos { get; set; }
        private int poder { get; set; }
        private double precision { get; set; }
        private int pp { get; set; }

        // CONSTRUCTORES
        public Movimiento()
        {
            this.tipos = new List<string>();
        }
        public Movimiento(string nombre, List<string> tipos, int poder,double precision, int pp)
        {
            SetNombre(nombre);
            SetTipo(tipos);
            SetPoder(poder);
            SetPrecision(precision);
            SetPP(pp);
        }
        // GETTERS Y SETTERS
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                nombre = nombre;
            }
            else
            {
                nombre = "Desconocido";
            }
        }

        public List<string> GetTipo()
        {
            return tipos;
        }

        public void SetTipo(List<string> tipo)
        {
            if (tipo != null)
            {
                this.tipos = tipo;
            }
            else
            {
                this.tipos = new List<string>();
            }
        }

        public int GetPoder()
        {
            return poder;
        }

        public void SetPoder(int poder)
        {
            if (poder > 0)
            {
                poder = poder;
            }
            else
            {
                poder = 0;
            }
        }
        public double GetPrecision()
        {
            return precision;
        }
        public void SetPrecision(double precision)
        {
            if (precision >0)
            {
                precision = precision;
            }
            else
            {
                precision = 0;
            }
        }
        public int GetPP()
        {
            return pp;
        }
        public void SetPP(int pp)
        {
            if (pp > 0)
            {
                pp = pp;
            }
            else
            {
                pp = 0;
            }
        }
        // TOSTRING
        public override string ToString()
        {
            return $"Nombre: {nombre} - Tipo: {tipos} - Poder: {poder}";
        }

        // METODOS
    }
}
