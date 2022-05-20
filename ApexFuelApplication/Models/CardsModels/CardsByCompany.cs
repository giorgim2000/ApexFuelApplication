using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApexFuelApplication.Models
{
    public class CardsByCompany
    {
        [DataMember(Order = 1)]
        public string card_id { get; set; }
        [DataMember(Order = 2)]
        public string owner_name { get; set; }
        
        [DataMember(Order = 3)]
        public DateTime crtime { get; set; }
        [DataMember(Order = 4)]
        public bool isbasic { get; set; }
        [DataMember(Order = 5)]
        public string pincode { get; set; }
        [DataMember(Order = 6)]
        public bool spend { get; set; }
        [DataMember(Order = 7)]
        public int fuel_id { get; set; }
        [DataMember(Order = 8)]
        public decimal rcount { get; set; }
        [DataMember(Order = 9)]
        public decimal rcount_nolife { get; set; }
        [DataMember(Order = 10)]
        public string code { get; set; }
        [DataMember(Order = 11)]
        public string fuelname { get; set; }
        [DataMember(Order = 12)]
        public string owner_mobile { get; set; }
        [DataMember(Order = 13)]
        public string owner_car { get; set; }
    }
}
