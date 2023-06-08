using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemon.Models;

namespace Pokemon.Pages
{
    public class Ejercicio1cshtmlModel : PageModel
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
