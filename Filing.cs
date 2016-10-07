using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SevenShadow.TagniFi
{
    [DataContract(Name = "filing")]
    public class Filing
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "html_link")]
        public string Html_Link { get; set; }

        [DataMember(Name = "Date")]
        public DateTime Date { get; set; }
        
        [DataMember(Name = "links")]
        public LinkCollection Links { get; set; }
        
       public Filing()
        {
            Links = new LinkCollection();
        }
    }
}
