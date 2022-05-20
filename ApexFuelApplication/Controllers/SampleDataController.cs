using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ApexFuelApplication.Models;
using ApexFuelApplication.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace ApexFuelApplication.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        private readonly CardServices _service;
        public SampleDataController(CardServices service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<object> Get(DataSourceLoadOptions loadOptions) {
            var dataSource = await _service.GetCardsByCompany();
            return DataSourceLoader.Load(dataSource.Result, loadOptions);
        }

    }
}