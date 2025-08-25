using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using COP2839_A1_JK.Models;
using System.Security.Cryptography.X509Certificates;

namespace COP2839_A1_JK.Controllers
{
	public class BookController : Controller
	{
		public static List<Book> books = new List<Book>
			{
				new Book { Id = 1, Title = "Murach's C#", Author = "Boehm & Murach" },
				new Book { Id = 2, Title = "Head First C#", Author = "Stellman & Greene" }
			};

		public IActionResult Index()
		{
			return View(books);
		}

		[HttpGet]
		public IActionResult AddBook()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddBook(Book model)
		{
			if (ModelState.IsValid)
			{
				model.Id = books.Count + 1;
				books.Add(model);
				return RedirectToAction("Index");
			}
			return View(model);
		}
	}
}
