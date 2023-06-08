using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPokemon
{
    internal class Equipo
    {
        // Atributos
        private const int maximoEquipo = 10;
        private List<Pokemon> pokemons { get; set; }

        //Constructores
        public Equipo() 
        { 
            this.pokemons = new List<Pokemon>();
        }

        public Equipo(List<Pokemon> pokemons)
        {
            this.pokemons = pokemons;
        }
        // Getters y Setters
        public List<Pokemon> GetPokemons()
        {
            return this.pokemons;
        }
        public void SetPokemons(List<Pokemon> pokemons)
        {
            if (pokemons != null)
            {
                this.pokemons = pokemons;
            }
            else
            {
                this.pokemons = new List<Pokemon>();
            }
        }
        // Tostring
        public override string ToString()
        {
            string Linea = $"Los pokemons de el equipo son:";
            pokemons.ForEach(pokemon => Linea += $"{pokemon.ToString()}");
            Linea += "--------------------------------------------------";
            return Linea;
        }
        // Metodos
    }
}
