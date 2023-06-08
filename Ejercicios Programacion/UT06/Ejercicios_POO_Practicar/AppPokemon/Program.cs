using AppPokemon;
using System;
namespace apppokemon
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Pokemon> listaPokemon = new List<Pokemon>();

            Pokemon pikachu = new Pokemon("Pikachu", new List<string> { "Eléctrico" }, 25);
            listaPokemon.Add(pikachu);

            Pokemon charizard = new Pokemon("Charizard", new List<string> { "Fuego", "Volador" }, 36);
            listaPokemon.Add(charizard);

            Pokemon bulbasaur = new Pokemon("Bulbasaur", new List<string> { "Planta", "Veneno" }, 10);
            listaPokemon.Add(bulbasaur);



            
        }
    }
}