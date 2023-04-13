using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hue04.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Image { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            DateTime now = DateTime.Now;

            if (now.Minute % 2 == 0)
            {
                Console.WriteLine("Die Minute ist gerade.");
                this.Image = "BrahmaGBC.jpg";
            }
            else
            {
                Console.WriteLine("Die Minute ist ungerade.");
                this.Image = "BrahmaSR.jpg";
            }
        }
    }
}