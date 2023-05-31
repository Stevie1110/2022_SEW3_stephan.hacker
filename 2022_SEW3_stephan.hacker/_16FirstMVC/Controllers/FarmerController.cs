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

		public IActionResult Detail(string id)		//kommt per URL-Parameter
		{
			Farmer f = model.Farmers.Where( f => f.LastName == id).FirstOrDefault(); 
			//model.Farmers.Min( f => f.Birthday ) überprüft wer der älteste ist
			return View(f);		// --> View Detail
		}

		[HttpPost]
		public IActionResult Edit(string id, Farmer farmer) 
		{
            // wir haben noch keine Datenbank in der wir persistente Änderungen speichern können
            Farmer f = model.Farmers.Where(f => f.LastName == id).FirstOrDefault();
			// f mit den Daten vom farmer updaten
			// danach speichern
			return RedirectToAction("Index");
        }
    }
}
