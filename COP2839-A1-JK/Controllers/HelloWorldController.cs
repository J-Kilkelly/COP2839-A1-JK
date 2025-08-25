using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace COP2839_A1_JK.Controllers
{
	public class BookController : Controller
	{
		// GET: /Book/
		public string Index()
		{
			return "This is my default action FROM book controller.";
		}

		// GET: /Book/Welcome/
		public string Welcome()
		{
			return "This is the Welcome action methoD...";
		}
	}
}
