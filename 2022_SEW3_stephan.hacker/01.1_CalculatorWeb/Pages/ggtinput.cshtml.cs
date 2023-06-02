using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _01._1_CalculatorWeb.Pages
{
    public class ggtinputModel : PageModel
    {

		public void OnGet()
		{
		}

		[HttpPost]
		public IActionResult OnPostCalculateggT(int number1, int number2)
		{
			return RedirectToPage("ggtcalculator", new { number1 = number1, number2 = number2 });
		}
	}
}

