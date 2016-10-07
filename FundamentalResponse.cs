
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    public class FundamentalResponse : ITagniFiResponse
    {
        public TagniFiRequest Request { get; set; }
        public string RawResponse { get; set; }

        [DataMember(Name = "fundatmentals")]
        public List<Fundamental> Fundamentals { get; set; }

        public FundamentalResponse()
        {
            Fundamentals = new List<Fundamental>();
        }

    }
}
