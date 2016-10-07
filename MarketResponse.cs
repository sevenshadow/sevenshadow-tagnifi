
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    public class MarketResponse : ITagniFiResponse
    {
        public TagniFiRequest Request { get; set; }
        public string RawResponse { get; set; }

        [DataMember(Name = "markets")]
        public List<Market> Markets { get; set; }

        public MarketResponse()
        {
            Markets = new List<Market>();
        }
       

    }
}
