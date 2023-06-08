using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPokemon
{
    internal class Entrenador
    {
        // Atributos
        private string nombre { get; set; }
        private Equipo equipo { get; set; }
        private List<Pokemon> pokedexs { get; set; }
        // Constructores
        public Entrenador()
        {

        }
        public Entrenador(string nombre, Equipo equipo)
        {
            SetNombre(nombre);
            SetEquipo(equipo);
            this.pokedexs = new List<Pokemon>();
        }

        // Getters y Setters
        public string GetNombre()
        {
            return nombre;
        }
        public Equipo GetEquipo()
        {
            return equipo;
        }
        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
            else
            {
                this.nombre = "Algo ha salido mal";
            }  
        }
        public void SetEquipo(Equipo equipo)
        {
            if (equipo != null)
            {
                this.equipo = equipo;
            }
            else
            {
                this.equipo = equipo;
            }
        }
        public void SetPokedex(List<Pokemon> pokedexs)
        {
            if (pokedexs != null)
            {
                this.pokedexs = pokedexs;
            }
            else
            {
                this.pokedexs = new List<Pokemon>();
            }
        }
        public List<Pokemon> GetPokemons()
        {
            return pokedexs;
        }
        // To String
        public override string ToString()
        {
            string linea = "Los datos del entrenador:\n";
            linea += $"Nombre: {this.nombre}\n";
            linea += $"El equipo: {this.equipo.ToString()}\n";
            linea += $"Los pokemons almacenado en la pokedex:\n";
            pokedexs.ForEach(pokemon=> linea += pokemon.ToString());
            return linea;
        }
        // Metodos
    }
}
