using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Santarsieri.Andrea._5H.PrimaWeb.Models;

namespace Santarsieri.Andrea._5H.PrimaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Persone()
        {
            List<Persona> P = new List<Persona>();
           
                P.Add(new Persona{Id=1,Nome="Pippo",Cognome="Baudo"});
                P.Add(new Persona{Id=2,Nome="Luca",Cognome="Gianni"});
            return View(P);
            
             
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
