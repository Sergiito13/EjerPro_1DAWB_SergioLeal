using Juego_Pokemon;

namespace gamepokemon
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Creación de instancias de movimientos
            Movimiento movimiento1 = new Movimiento("Placaje", new List<string> { "Normal" }, 40, 100, 35);
            Movimiento movimiento2 = new Movimiento("Lanzallamas", new List<string> { "Fuego" }, 90, 75, 15);
            Movimiento movimiento3 = new Movimiento("Hoja Afilada", new List<string> { "Planta" }, 70, 95, 20);
            Movimiento movimiento4 = new Movimiento("Gruñido", new List<string> { "Normal" }, 0, 100, 40);
            Movimiento movimiento5 = new Movimiento("Pistola Agua", new List<string> { "Agua" }, 40, 100, 25);
            Movimiento movimiento6 = new Movimiento("Mordisco", new List<string> { "Normal" }, 60, 100, 25);
            Movimiento movimiento7 = new Movimiento("Impactrueno", new List<string> { "Eléctrico" }, 40, 100, 30);
            Movimiento movimiento8 = new Movimiento("Rayo", new List<string> { "Eléctrico" }, 90, 75, 15);
            Movimiento movimiento9 = new Movimiento("Ataque Rápido", new List<string> { "Normal" }, 40, 100, 30);
            Movimiento movimiento10 = new Movimiento("Bola Voltio", new List<string> { "Eléctrico" }, 80, 90, 15);
            Movimiento movimiento11 = new Movimiento("Psíquico", new List<string> { "Psíquico" }, 90, 100, 10);
            Movimiento movimiento12 = new Movimiento("Confusión", new List<string> { "Psíquico" }, 50, 100, 25);
            Movimiento movimiento13 = new Movimiento("Hiperrayo", new List<string> { "Normal" }, 150, 90, 5);
            Movimiento movimiento14 = new Movimiento("Lanza Lodo", new List<string> { "Veneno" }, 65, 85, 10);
            Movimiento movimiento15 = new Movimiento("Golpe Karate", new List<string> { "Lucha" }, 50, 100, 25);
            Movimiento movimiento16 = new Movimiento("Golpe Bajo", new List<string> { "Lucha" }, 80, 90, 15);
            Movimiento movimiento17 = new Movimiento("Rueda Fuego", new List<string> { "Fuego" }, 60, 100, 20);
            Movimiento movimiento18 = new Movimiento("Descanso", new List<string> { "Normal" }, 0, 100, 10);
            Movimiento movimiento19 = new Movimiento("Hiperrayo", new List<string> { "Normal" }, 150, 90, 5);
            Movimiento movimiento20 = new Movimiento("Rayo Solar", new List<string> { "Planta" }, 120, 100, 10);
            Movimiento movimiento21 = new Movimiento("Tornado", new List<string> { "Volador" }, 110, 70, 10);
            Movimiento movimiento22 = new Movimiento("Hidrobomba", new List<string> { "Agua" }, 110, 80, 5);
            Movimiento movimiento23 = new Movimiento("Terremoto", new List<string> { "Tierra" }, 100, 100, 10);
            Movimiento movimiento24 = new Movimiento("Psíquico", new List<string> { "Psíquico" }, 90, 100, 10);
            Movimiento movimiento25 = new Movimiento("Giro Bola", new List<string> { "Acero" }, 60, 100, 20);
            Movimiento movimiento26 = new Movimiento("Lanzamiento", new List<string> { "Normal" }, 1, 100, 30);
            Movimiento movimiento27 = new Movimiento("Cabezazo Zen", new List<string> { "Psíquico" }, 80, 90, 15);
            Movimiento movimiento28 = new Movimiento("Triturar", new List<string> { "Siniestro" }, 80, 100, 15);
            Movimiento movimiento29 = new Movimiento("Onda Ígnea", new List<string> { "Fuego" }, 60, 100, 20);
            Movimiento movimiento30 = new Movimiento("Garra Umbría", new List<string> { "Fantasma" }, 70, 100, 15);
            Movimiento movimiento31 = new Movimiento("Hidrobomba", new List<string> { "Agua" }, 110, 80, 5);
            Movimiento movimiento32 = new Movimiento("Psicocarga", new List<string> { "Psíquico" }, 80, 100, 10);
            Movimiento movimiento33 = new Movimiento("Rayo Hielo", new List<string> { "Hielo" }, 90, 100, 10);
            Movimiento movimiento34 = new Movimiento("Lanza Rocas", new List<string> { "Roca" }, 50, 90, 15);
            Movimiento movimiento35 = new Movimiento("Tajo Aéreo", new List<string> { "Volador" }, 75, 95, 20);
            Movimiento movimiento36 = new Movimiento("Hiperrayo Solar", new List<string> { "Planta" }, 150, 90, 5);
            Movimiento movimiento37 = new Movimiento("Hiperrayo de Fuego", new List<string> { "Fuego" }, 150, 90, 5);
            Movimiento movimiento38 = new Movimiento("Rayo Carga", new List<string> { "Eléctrico" }, 80, 100, 10);
            Movimiento movimiento39 = new Movimiento("Excavar", new List<string> { "Tierra" }, 80, 100, 10);
            Movimiento movimiento40 = new Movimiento("Ciclón", new List<string> { "Volador" }, 100, 75, 10);
            Movimiento movimiento41 = new Movimiento("Hidropulso", new List<string> { "Agua" }, 65, 100, 20);



            // Creación de instancias de Pokémon
            Pokemon pokemon1 = new Pokemon("Charizard", 80, 75, 36, new List<string> { "Fuego", "Volador" }, new List<Movimiento> { movimiento1, movimiento2 });
            Pokemon pokemon2 = new Pokemon("Blastoise", 79, 83, 36, new List<string> { "Agua" }, new List<Movimiento> { movimiento5, movimiento6, movimiento22 });
            Pokemon pokemon3 = new Pokemon("Venusaur", 80, 82, 36, new List<string> { "Planta", "Veneno" }, new List<Movimiento> { movimiento3, movimiento14, movimiento20 });
            Pokemon pokemon4 = new Pokemon("Pikachu", 35, 55, 20, new List<string> { "Eléctrico" }, new List<Movimiento> { movimiento7, movimiento8, movimiento9 });
            Pokemon pokemon5 = new Pokemon("Alakazam", 55, 50, 16, new List<string> { "Psíquico" }, new List<Movimiento> { movimiento11, movimiento12, movimiento24 });
            Pokemon pokemon6 = new Pokemon("Machamp", 90, 80, 40, new List<string> { "Lucha" }, new List<Movimiento> { movimiento15, movimiento16, movimiento25 });
            Pokemon pokemon7 = new Pokemon("Arcanine", 90, 80, 45, new List<string> { "Fuego" }, new List<Movimiento> { movimiento2, movimiento17, movimiento21 });
            Pokemon pokemon8 = new Pokemon("Snorlax", 160, 110, 50, new List<string> { "Normal" }, new List<Movimiento> { movimiento4, movimiento18, movimiento19 });
            Pokemon pokemon9 = new Pokemon("Gyarados", 95, 79, 30, new List<string> { "Agua", "Volador" }, new List<Movimiento> { movimiento5, movimiento6, movimiento23 });
            Pokemon pokemon10 = new Pokemon("Dragonite", 91, 95, 55, new List<string> { "Dragón", "Volador" }, new List<Movimiento> { movimiento26, movimiento27, movimiento35 });
            Pokemon pokemon11 = new Pokemon("Gengar", 60, 45, 25, new List<string> { "Veneno", "Fantasma" }, new List<Movimiento> { movimiento30, movimiento32, movimiento36 });
            Pokemon pokemon12 = new Pokemon("Tyranitar", 100, 95, 50, new List<string> { "Roca", "Siniestro" }, new List<Movimiento> { movimiento28, movimiento34, movimiento40 });
            Pokemon pokemon13 = new Pokemon("Articuno", 90, 85, 50, new List<string> { "Hielo", "Volador" }, new List<Movimiento> { movimiento33, movimiento39, movimiento41 });

            List<Pokemon> listaPokemon = new List<Pokemon>();

            // Agregar los Pokémon a la lista
            listaPokemon.Add(pokemon1);
            listaPokemon.Add(pokemon2);
            listaPokemon.Add(pokemon3);
            listaPokemon.Add(pokemon4);
            listaPokemon.Add(pokemon5);
            listaPokemon.Add(pokemon6);
            listaPokemon.Add(pokemon7);
            listaPokemon.Add(pokemon8);
            listaPokemon.Add(pokemon9);
            listaPokemon.Add(pokemon10);
            listaPokemon.Add(pokemon11);
            listaPokemon.Add(pokemon12);
            listaPokemon.Add(pokemon13);

            listaPokemon.ForEach(pokemon => Console.WriteLine(pokemon.ToString()));


        }
    }
}