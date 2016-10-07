using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.ComponentModel;
using System.Reflection;

namespace SevenShadow.TagniFi
{
    public enum PeriodType
    {
        [Description("annual")]
        Annual = 0,

        [Description("quarterly")]
        Quarterly = 1,

    }

    public enum StatementType
    {
        [Description("balance_sheet_statement")]
        BalanceSheetStatement = 0,

        [Description("income_statement")]
        IncomeStatement = 1,

        [Description("cash_flow_statement")]
        CashFlowStatement = 2,

    }

    public enum TagnifiQueryType
    {
        [Description("fundamentals")]
        Fundamentals = 0,

        [Description("companies")]
        Companies = 1,

        [Description("filings")]
        Filings = 2,

        [Description("markets")]
        Markets = 3,
    }

    public enum TagnifiParameters
    {
        [Description("company")]
        Company = 0,
        
        [Description("period_type")]
        PeriodType = 1,

        [Description("statement")]
        Statement = 2,

        [Description("fiscal_year")]
        FiscalYear = 3,

        [Description("fiscal_quarter")]
        FiscalQuarter = 4,

        [Description("periods")]
        Periods = 5,

        [Description("tag")]
        Tag = 6,
        [Description("relative_period")]
        RelativePeriod = 7,
        
    }
}
