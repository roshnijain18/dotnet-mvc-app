using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DotnetMvcApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ (case-insensitive also works)

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        // GET: /HelloWorld/WelcomeWith?name=Roshni&numTimes=4
        // Requires using System.Text.Encodings.Web;
        public IActionResult WelcomeWith(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // GET: HelloWorld/Welcome/3?name=Roshni
        public string WelcomeWithId(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}