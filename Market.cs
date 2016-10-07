using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SevenShadow.TagniFi
{
    [DataContract(Name = "market")]
    public class Market
    {
        [DataMember(Name = "company")]
        public Company Company { get; set; }

        [DataMember(Name = "prices")]
        public List<MarketPrice> Prices { get; set; }

        


    }
}
