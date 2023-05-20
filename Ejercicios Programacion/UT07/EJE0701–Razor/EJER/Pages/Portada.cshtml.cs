using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJER.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class PortadaModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
