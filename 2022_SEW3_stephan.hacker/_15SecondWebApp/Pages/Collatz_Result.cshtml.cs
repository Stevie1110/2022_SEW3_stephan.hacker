using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
	public class Collatz_ResultModel : PageModel
	{
		public string Result { get; set; }
		public string Source { get; set; }
		public void OnGet(string result, string source)
		{
			Result = result;
			Source = source;
		}
	}
}
