using ApexFuelApplication.Services;
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
        private readonly CardServices _service;
        public CardsController(CardServices service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var cards = await _service.GetCardsByCompany();
            return View(cards);
        }
    }
}
