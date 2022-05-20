using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApexFuelApplication.Controllers
{
    public class CardsController : Controller
    {
        private readonly HttpClient client;
        public CardsController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
