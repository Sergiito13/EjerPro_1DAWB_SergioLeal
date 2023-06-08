using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokemon.Models;

namespace Prueba.Pages
{
    public class IndexModel : PageModel
    {
        public readonly MisDatos Datos;

        public IndexModel(MisDatos datos)
        {
            Datos = datos;
        }

        public void OnGet()
        {

        }
    }
}