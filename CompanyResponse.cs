
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    public class CompanyResponse : ITagniFiResponse
    {
        public TagniFiRequest Request { get; set; }
        public string RawResponse { get; set; }
        public List<Company> Companies { get; set; }

        public CompanyResponse()
        {
            Companies = new List<Company>(); 
        }
       

    }
}
