using ApexFuelApplication.Extensions;
using ApexFuelApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApexFuelApplication.Services
{
    public class CardServices
    {
        private readonly HttpClient client;
        public CardServices(HttpClient http)
        {
            client = http;
        }

        public async Task<GetCardsByCompanyResponseModel> GetCardsByCompany()
        {
            var response = new GetCardsByCompanyResponseModel();
            string encoded = System.Convert.ToBase64String(Encoding.UTF8
                               .GetBytes("test" + ":" + "9"));
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);
            var resp = await client.GetAsync("/GetCardsByCompany.json");
            if (resp.IsSuccessStatusCode)
            {
                var rawData = await resp.Content.ReadAsStringAsync();
                var cardData = CardExtensions.deserializeData(rawData);
                response = cardData;
            }
            return response;
        }
    }
}
