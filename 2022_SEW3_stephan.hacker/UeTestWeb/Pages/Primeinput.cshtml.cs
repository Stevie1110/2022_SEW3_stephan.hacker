using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UeTestWeb.Pages
{
    public class PrimeinputModel : PageModel
    {
        public void OnGet()
        {
		}

		[HttpPost]
		public IActionResult OnPostCalculatePrimefactors(int number)
		{
			return RedirectToPage("Primefactors", new { number = number });
		}
	}
}
