using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexFuelApplication.Models.CardsModels
{
    public class CardDto
    {
        public string CardId { get; set; }
        public bool IsBasic { get; set; }
        public string OwnerName { get; set; }
        public string CardName => IsBasic ? " კომპანიის მთავარი ბარათი" : $"{CardId} - {OwnerName}";
        public string code { get; set; }
        public string fuelname { get; set; }
        public decimal rcount { get; set; }
        
    }
}
