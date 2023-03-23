using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
    public class SubtraktionModel : PageModel
    {
        public double? Result { get; set; }
        public string Calculation { get; set; }
        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPostCalculate1(double subtrahend, double minuend)
        {
            Result = subtrahend - minuend;
            Calculation = $"{subtrahend} - {minuend} = {Result}";
            return Page();      //wir bleiben auf der gleichen Seite
        }

        [HttpPost]
        public IActionResult OnPostCalculateAndRedirect1(double subtrahend, double minuend)
        {
            double differenz = subtrahend - minuend;
            return RedirectToPage("Result", new { result = differenz, calculation = $"{subtrahend} - {minuend} = " , source="Subtraktion"});

        }
    }
}
