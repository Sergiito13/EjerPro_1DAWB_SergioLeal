using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemon.Models;

namespace Pokemon.Pages
{
    public class buscarpokemonModel : PageModel
    {
        public readonly MisDatos Datos;


        public buscarpokemonModel(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}