using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJER.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]

    public class InicioModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
