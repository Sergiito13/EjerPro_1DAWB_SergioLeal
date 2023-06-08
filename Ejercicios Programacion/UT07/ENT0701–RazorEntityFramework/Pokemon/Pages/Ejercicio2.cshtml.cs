using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemon.Models;

namespace Pokemon.Pages
{
    public class Ejercicio2Model : PageModel
    {
        public readonly MisDatos Datos;

        public Ejercicio2Model(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}
