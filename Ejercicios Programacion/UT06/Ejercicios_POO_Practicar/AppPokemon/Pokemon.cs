using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppPokemon
{
    internal class Pokemon
    {
        // Atributos
        private string nombre { get; set; }
        private List<string> tipo { get; set; }

        private int nivel { get; set; }

        // Constructores
        public Pokemon()
        {
            this.tipo = new List<string>();
        }
        public Pokemon(string nombre, List<string> tipo, int nivel)
        {
            SetNombre(nombre);
            SetTipo(tipo);
            SetNivel(nivel);
        }

        // Getters y Setters
        public void SetNombre(string nombrePokemon)
        {
            if (!string.IsNullOrEmpty(nombrePokemon))
            {
                this.nombre = nombrePokemon;
            }
            else
            {
                this.nombre = "Algo ha salido mal";
            }
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetTipo(List<string> tipo)
        {
            if (tipo != null)
            {
                this.tipo = tipo;
            }
            else
            {
                this.tipo = new List<string>();
            }
        }

        public List<string> GetTipo()
        {
            return this.tipo;
        }
        public void SetNivel(int nivel)
        {
            if (nivel >= 0)
            {
                this.nivel = nivel;
            }
            else
            {
                this.nivel = -1;
            }
        }
        // ToString
        public override string ToString()
        {
            string linea = $"Los pokemon son:\n";
            linea += $"El nombre es: {this.nombre}\n";
            linea += $"Los tipos son: ";
            tipo.ForEach(tipo1 => linea += $"{tipo1}");
            linea += $"El nivel: {this.nivel}";
            return linea;
        }
        
        // Metodos

    }
}
