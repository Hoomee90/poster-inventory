using Microsoft.AspNetCore.Mvc;

namespace PosterInventory.Controllers
{
	public class HomeController : Controller
	{

		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
		
	}
}