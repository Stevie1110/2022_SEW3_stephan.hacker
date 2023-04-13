using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue05.Pages
{
    public class GehzeitModel : PageModel
    {
        public decimal stunden { get; set; }
        public decimal minuten { get; set; }
        public decimal Abwaerts { get; set; }
        public string? Solution { get; set; }
        public decimal Aufwaerts { get; set; }
        public decimal Kilometer { get; set; }
        public decimal Diff { get; set; }

        [HttpPost]
        public IActionResult OnPostRechner(decimal Aufwaerts, decimal Abwaerts, decimal Kilometer)
        {
            this.Aufwaerts = Aufwaerts / 300;
            this.Abwaerts = Abwaerts / 500;
            this.Kilometer = Kilometer / 4;
            this.Diff = this.Aufwaerts + this.Abwaerts;

            if (Diff < this.Kilometer)
            {
                Diff = this.Diff / 2;
            }
            else
            {
                Kilometer = this.Kilometer / 2;
            }
            stunden = Diff + Kilometer;

            minuten = (stunden - Math.Truncate(stunden)) * 60;            //Funktion von Raphael Völker

            if (minuten > 45)
            {
                minuten = 0;
                stunden = stunden + stunden;
            }
            else if (minuten > 30)
            {
                minuten = 45;
            }
            else if (minuten > 15)
            {
                minuten = 30;
            }
            else if (minuten > 0)
            {
                minuten = 15;
            }
            Solution = $"{Math.Truncate(stunden)} Stunden und {minuten} Minuten";       //Funktion Raphael Völker
            return Page();
        }
    }
}
