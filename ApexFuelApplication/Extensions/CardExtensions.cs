using ApexFuelApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApexFuelApplication.Extensions
{
    public static class CardExtensions
    {
        public static GetCardsByCompanyResponseModel deserializeData(string json)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GetCardsByCompanyResponseModel));
                var res = ser.ReadObject(ms) as GetCardsByCompanyResponseModel;
                ms.Close();
                return res;
            }
        }
    }
}
