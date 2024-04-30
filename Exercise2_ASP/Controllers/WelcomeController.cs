using Exercise2_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Exercise2_ASP.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomeDefault()
        {
            ViewBag.Message = "Bienvenue dans ma nouvelle application!";
            return View();
        }

        public IActionResult WelcomeName(string prenom, string nom)
        {
            ViewBag.Message2 = $"Salut {prenom} {nom} ! Bienvenue dans ma nouvelle application!";
            return View("WelcomeName");
        }

        public string WelcomeNameEssai()
        {
            return "<h2>Bienvenu dans mon site web</h2>";
        }

        public ContentResult WelcomeNameHtml()
        {
            return Content("<h2>Bienvenu dans mon site web</h2>", "text/html");
        }

        public IActionResult WelcomeEcercise3()
        {
            return View();
        }

        public ContentResult ShowPdf()
        {
            string path = Url.Content("~/File/Notes.pdf");
            return Content($"<iframe src=\"{path}\" width=\"100%\" height=\"100%\">Bienvenu dans mon site web</iframe>", "text/html");
        }

        public IActionResult Exercise5()
        {
            List<Client> list = new List<Client>();
            Client client1 = new Client(1,"Dion","Jessi","Jessi@yahoo.com");
            Client client2 = new Client(2, "Hussein", "Rame", "Rame@yahoo.com");
            list.Add(client1);
            list.Add(client2);

            var json = JsonSerializer.Serialize(list);

            return Content(json, "application/json");
        }

        public IActionResult Exercise6()
        {
            // Redirection vers la méthode d'action de la question 1
            return RedirectToAction("WelcomeDefault");
        }
    }
}
