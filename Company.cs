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
    public class Company
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "sic_code")]
        public int Sic_Code { get; set; }

        [DataMember(Name = "web_site")]
        public string Web_Site { get; set; }

        [DataMember(Name = "ticker")]
        public string Ticker { get; set; }

        [DataMember(Name = "industry_template")]
        public string Industry_Template { get; set; }

        [DataMember(Name = "fundamentals_history_link")]
        public string Fundamentals_History_Link { get; set; }


    }
}
