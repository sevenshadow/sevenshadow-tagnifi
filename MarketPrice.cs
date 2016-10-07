using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SevenShadow.TagniFi
{
    [DataContract(Name = "company")]
    public class MarketPrice
    {
        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "close")]
        public decimal Close { get; set; }

        [DataMember(Name = "open")]
        public decimal Open { get; set; }

        [DataMember(Name = "high")]
        public decimal High { get; set; }

        [DataMember(Name = "low")]
        public decimal Low { get; set; }

        [DataMember(Name = "volume")]
        public decimal Volume { get; set; }

        [DataMember(Name = "adjusted")]
        public bool Adjusted { get; set; }


    }
}
