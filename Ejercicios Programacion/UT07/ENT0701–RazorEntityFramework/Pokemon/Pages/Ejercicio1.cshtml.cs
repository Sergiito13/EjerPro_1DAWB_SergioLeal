using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemon.Models;

namespace Pokemon.Pages
{
    public class Ejercicio1Model : PageModel
    {
        public readonly MisDatos Datos;

        public Ejercicio1Model(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}
