using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
      [DataContract(Name = "link")]
  
    public class LinkCollection
    {
          [DataMember(Name = "filing")]
          public string Filing { get; set; }

          [DataMember(Name = "company")]
          public string Company { get; set; }

          [DataMember(Name = "type")]
          public string Type { get; set; }

          [DataMember(Name = "href")]
          public string Href { get; set; }

    }
}
