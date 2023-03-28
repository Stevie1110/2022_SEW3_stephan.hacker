using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
	public class Collatz_ResultModel : PageModel
	{
		public double Result { get; set; }
		
		public IActionResult OnPostCalculate(int collatz)
		{
			double puff = 0;
			while (collatz != null)
			{
				if (collatz % 2 == 0 ) {
					puff+= collatz / 2;
				}
				else
				{
					puff = 3 * collatz + 1;
				}
			}

		}

		public void OnGet(double result)
		{
			Result = result;

		}
	}
}
