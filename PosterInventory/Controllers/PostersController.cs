using Microsoft.AspNetCore.Mvc;
using PosterInventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace PosterInventory.Controllers
{
	public class PostersController : Controller
	{
		private readonly PosterInventoryContext _db;
		
		public PostersController(PosterInventoryContext db)
		{
			_db = db;
		}
		
		public ActionResult Index()
		{
			List<Poster> model = _db.Posters.ToList();
			return View(model);
		}
		
		public ActionResult Create()
		{
		return View();
		}
		
		[HttpPost]
		public ActionResult Create(Poster poster)
		{
			_db.Posters.Add(poster);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
		
		public ActionResult Details(int id)
		{
			Poster thisPoster = _db.Posters.FirstOrDefault(poster => poster.PosterId == id);
			return View(thisPoster);
		}
	}
}