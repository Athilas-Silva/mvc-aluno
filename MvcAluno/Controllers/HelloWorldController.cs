using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numVezes = 1)
        {
            ViewData["Mensagem"] = "Ola " + name;
            ViewData["NumVezes"] = numVezes;

            return View();
        }
    }
}