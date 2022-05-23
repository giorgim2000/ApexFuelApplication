using ApexFuelApplication.Models.CardsModels;
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
            var data = await _service.GetCardsByCompany();
            var cards = data.Result.Select(i => new CardDto()
            {
                CardId = i.card_id,
                IsBasic = i.isbasic,
                OwnerName = i.owner_name,
                code = i.code,
                fuelname = i.fuelname,
                rcount = i.rcount
            }).ToList();
            return View(cards);
        }
    }
}
