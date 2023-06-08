namespace Juego_Pokemon
{
    internal class Pokemon
    {
        // ATRIBUTOS
        private string nombre { get; set; }
        private int salud { get; set; }
        private int nivel { get; set; }
        private int experiencia { get; set; }
        private List<string> tipos { get; set; }
        private List<Movimiento> movimientos { get; set; }

        // CONSTRUCTORES
        public Pokemon()
        {
            this.tipos = new List<string>();
            this.movimientos = new List<Movimiento>();
        }

        public Pokemon(string nombre, int salud, int nivel, int experiencia, List<string> tipos, List<Movimiento> movimientos)
        {
            SetNombre(nombre);
            SetSalud(salud);
            SetNivel(nivel);
            SetExperiencia(experiencia);
            SetTipos(tipos);
            SetMovimientos(movimientos);
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
                this.nombre = nombre;
            }
            else
            {
                this.nombre = "Nombre desconocido";
            }
        }

        public int GetSalud()
        {
            return salud;
        }

        public void SetSalud(int salud)
        {
            if (salud >= 0)
            {
                this.salud = salud;
            }
            else
            {
                this.salud = 0;
            }
        }

        public int GetNivel()
        {
            return nivel;
        }

        public void SetNivel(int nivel)
        {
            if (nivel >= 0)
            {
                this.nivel = nivel;
            }
            else
            {
                this.nivel = 0;
            }
        }

        public int GetExperiencia()
        {
            return experiencia;
        }

        public void SetExperiencia(int experiencia)
        {
            if (experiencia >= 0)
            {
                this.experiencia = experiencia;
            }
            else
            {
                this.experiencia = 0;
            }
        }

        public List<string> GetTipos()
        {
            return tipos;
        }

        public void SetTipos(List<string> tipos)
        {
            if (tipos != null)
            {
                this.tipos = tipos;
            }
            else
            {
                this.tipos = new List<string>();
            }
        }

        public List<Movimiento> GetMovimientos()
        {
            return movimientos;
        }

        public void SetMovimientos(List<Movimiento> movimientos)
        {
            if (movimientos != null)
            {
                this.movimientos = movimientos;
            }
            else
            {
                this.movimientos = new List<Movimiento>();
            }
        }
        // TOSTRING
        public override string ToString()
        {
            return $"Nombre: {nombre} - Salud: {salud} - Nivel: {nivel} - Experiencia: {experiencia} - Tipos: {string.Join(", ", tipos)} - Movimientos: {string.Join(", ", movimientos)}";
        }
        // METODOS
    }
}

