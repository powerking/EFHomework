using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
	public class HelloWorldController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		//public string Index()
		//{
		//	return "This is my default action...";
		//}

		// 
		// GET: /HelloWorld/Welcome/ 
		public string Welcome()
		{
			return "This is the Welcome action method...";
		}

		//[Route("/Welcome2")]
		public string Welcome2(string name, int numTimes = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
		}
	}
}
