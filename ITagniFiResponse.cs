using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    internal interface ITagniFiResponse
    {
        TagniFiRequest Request { get; set; }
        string RawResponse { get; set; }
    }
}
