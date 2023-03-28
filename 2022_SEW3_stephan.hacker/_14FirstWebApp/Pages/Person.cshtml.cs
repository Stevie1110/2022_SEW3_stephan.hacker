using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14FirstWebApp.Pages
{
    public class PersonModel : PageModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Image { get; set; }

        public IList<string> Mails { get; set; }
        public void OnGet([FromRoute] int id, string image)     //[FromRoute]int id, string.....
        {
            if (id == 5)
            {
                this.FirstName = "Jakob";
                this.LastName = "Jehle";
                this.Mails = new List<string>();
                this.Mails.Add("jakob.jehle@josephinum.at");
                this.Mails.Add("bioerdbeeren@jehle.at");
            }
            else
            {
				this.FirstName = "Tobias";
				this.LastName = "Nagl";
				this.Mails = new List<string>();
				this.Mails.Add("tobias.nagl@josephinum.at");
				this.Mails.Add("gemuese@nagl.at");
			}

            if(image == "zwiebel")
            {
                this.Image = "zwiebel.jpg";
            }else if(image == "erdbeeren")
            {
				this.Image = "erdbeeren.jpg";
			}
			else
			{
				this.Image = "error.jpg";
			}
			//throw new InvalidOperationException("Jakob Jehle konnte nicht geladen werden");
		}
    }
}
