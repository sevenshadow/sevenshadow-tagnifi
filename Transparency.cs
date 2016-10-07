using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
       [DataContract(Name = "transparency")]
 
    public class Transparency
    {
           [DataMember(Name = "name")]
           public string Name { get; set; }

           [DataMember(Name = "value")]
           public string Value { get; set; }
           
           [DataMember(Name = "source")]
           public string Source { get; set; }

           [DataMember(Name = "operator")]
           public string Operator { get; set; }

        
    }
}
