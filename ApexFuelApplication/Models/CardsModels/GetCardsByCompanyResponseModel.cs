using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexFuelApplication.Models
{
    public class GetCardsByCompanyResponseModel
    {
        public ResponseStatus ResponseStatus { get; set; }
        public List<CardsByCompany> Result { get; set; }
    }
}
