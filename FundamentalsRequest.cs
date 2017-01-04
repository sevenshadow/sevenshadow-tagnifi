using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    public class FundamentalsRequest : TagniFiRequest
    {
        public string TickerSymbolOrCompanyId { get; set; }
        public PeriodType PeriodType { get; set; }
        public StatementType StatementType { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalQuarter { get; set; }
        public int Periods { get; set; }
        public string TagName { get; set; }
        public bool UseRelativePeriod { get; set; }
        public int RelativePeriod { get; set; }

        public int Limit { get; set; }

        public string Template { get; set; }


    }
}
