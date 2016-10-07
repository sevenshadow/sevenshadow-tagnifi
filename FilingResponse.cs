
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    public class FilingResponse : ITagniFiResponse
    {
        public TagniFiRequest Request { get; set; }
        public string RawResponse { get; set; }
        public List<Filing> Filings { get; set; }

        public FilingResponse()
        {
            Filings = new List<Filing>(); 
        }
       

    }
}
