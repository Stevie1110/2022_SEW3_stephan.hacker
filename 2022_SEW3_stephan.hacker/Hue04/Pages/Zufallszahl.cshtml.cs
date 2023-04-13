using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue04.Pages
{
    public class ZufallszahlModel : PageModel
    {
        public int Number { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        Random random = new Random();
        public void OnGet(int minimum, int maximum)
        {

            this.Number = random.Next(minimum, maximum);

            this.Minimum = minimum;

            this.Maximum = maximum;

        }
    }
}
