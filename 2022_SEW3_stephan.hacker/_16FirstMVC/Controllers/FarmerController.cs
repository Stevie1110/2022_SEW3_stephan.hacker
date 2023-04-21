using _16FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16FirstMVC.Controllers
{
	public class FarmerController : Controller
	{
		private FarmerModel model = new FarmerModel();
		public FarmerController() {
			model.Farmers.Add(new Farmer() { FirstName = "Felix", LastName = "Heidegger", Address = "Tulln", Birthday = new DateTime(2004, 12, 12) });
            model.Farmers.Add(new Farmer() { FirstName = "Benedikt", LastName = "Hager", Address = "Auersthal", Birthday = new DateTime(2004, 11, 18) });
            model.Farmers.Add(new Farmer() { FirstName = "Michael", LastName = "Haider", Address = "Raach", Birthday = new DateTime(2004, 11, 7) });
        }
		public IActionResult Index()
		{
			return View(model);		//es wird eine View mit dem Namen der Action gesucht, also Index
		}

		public IActionResult Detail()
		{
			return View();		// --> View Detail
		}
	}
}
