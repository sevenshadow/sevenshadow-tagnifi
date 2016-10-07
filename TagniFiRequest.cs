using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    public class TagniFiRequest
    {
        public string BaseApiUrl { get; set; }
        public string ApiKey { get; set; }
        public string EndPoint { get; set; }
        public HttpVerb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public TagniFiRequest()
        {
            ContentType = "text/xml";
            Method = HttpVerb.GET;
            ApiKey = string.Empty;
        }

  
    }
}
