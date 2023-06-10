using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemon.Models;

namespace Pokemon.Pages
{
    public class Ejercicio3Model : PageModel
    {
        public readonly MisDatos Datos;

        public Ejercicio3Model(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}
