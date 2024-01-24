using Microsoft.AspNetCore.Mvc;
using myLayout.Models;
using System.Collections.Generic;

namespace myLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Liste()
        {

            List<Tuto> tutos = new List<Tuto>()
        {
            new Tuto{Id = 1, Titre="title1" , Lien="Lien1"},
            new Tuto {Id = 2, Titre="title2" , Lien="Lien2" },
            new Tuto { Id = 3, Titre="title3" , Lien="Lien3"}
        };

            return View(tutos);
        }

        public IActionResult Forum()
        {
            return View();
        }
    }
}

