using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    public class TagniFiDataWrapper
    {

        #region Properties

        public string BaseApiUrl { get; set; }
        public string ApiKey { get; set; }

        #endregion

        #region Contstructors

        public TagniFiDataWrapper(string baseApiUrl, string apiKey)
        {
            ApiKey = apiKey;
            BaseApiUrl = baseApiUrl;
        }

        #endregion

        #region Search Fundamentals

        public FundamentalResponse GetFinancialStatements(FundamentalsRequest request)
        {
            if (request.ApiKey == string.Empty)
                request.ApiKey = ApiKey;

            string statementBaseUrl = "{0}{1}?{2}={3}&{4}={5}&{6}={7}";
            request.EndPoint = string.Format(statementBaseUrl, BaseApiUrl, GetEnumDescription(TagnifiQueryType.Fundamentals), GetEnumDescription(TagnifiParameters.Company), request.TickerSymbolOrCompanyId,
                GetEnumDescription(TagnifiParameters.PeriodType), GetEnumDescription(request.PeriodType),
                GetEnumDescription(TagnifiParameters.Statement), GetEnumDescription(request.StatementType));

            if (request.UseRelativePeriod)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.RelativePeriod) + "=" + request.RelativePeriod.ToString();

            if (request.FiscalYear > 0)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.FiscalYear) + "=" + request.FiscalYear.ToString();

            if (request.FiscalQuarter > 0  && request.PeriodType == PeriodType.Quarterly)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.FiscalQuarter) + "=" + request.FiscalQuarter.ToString();

            if (request.Periods > 0)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.Periods) + "=" + request.Periods.ToString();

            if (request.Limit > 0)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.Limit) + "=" + request.Limit.ToString();

            if (!string.IsNullOrEmpty(request.Template))
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.Template) + "=" + request.Template;

            RestClient client = new RestClient(request);
            string rawResponseString = client.MakeRequest();

            FundamentalResponse response = (FundamentalResponse)JsonConvert.DeserializeObject(rawResponseString, typeof(FundamentalResponse));
            
            response.Request = request;
            response.RawResponse = rawResponseString;

            return response;

        }

        public FundamentalResponse SearchFundamentals(FundamentalsRequest request)
        {
            if (request.ApiKey == string.Empty)
                request.ApiKey = ApiKey;

            string statementBaseUrl = "{0}{1}?{2}={3}&{4}={5}&{6}={7}";
            request.EndPoint = string.Format(statementBaseUrl, BaseApiUrl, GetEnumDescription(TagnifiQueryType.Fundamentals), GetEnumDescription(TagnifiParameters.Company), request.TickerSymbolOrCompanyId,
                GetEnumDescription(TagnifiParameters.PeriodType), GetEnumDescription(request.PeriodType),
                GetEnumDescription(TagnifiParameters.Tag), request.TagName);

            if (request.FiscalYear > 0 )
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.FiscalYear) + "=" + request.FiscalYear.ToString();

            if (request.FiscalQuarter > 0)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.FiscalQuarter) + "=" + request.FiscalQuarter.ToString();

            if (request.Periods > 0)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.Periods) + "=" + request.Periods.ToString();

            if (request.UseRelativePeriod)
            {
                request.EndPoint += "&relative_period=" + request.RelativePeriod.ToString();

            }
            if (request.Limit > 0)
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.Limit) + "=" + request.Limit.ToString();

            if (!string.IsNullOrEmpty(request.Template))
                request.EndPoint += "&" + GetEnumDescription(TagnifiParameters.Template) + "=" + request.Template;

            RestClient client = new RestClient(request);
            string rawResponseString = client.MakeRequest();

            FundamentalResponse response = (FundamentalResponse)JsonConvert.DeserializeObject(rawResponseString, typeof(FundamentalResponse));
           
            
            response.Request = request;
            response.RawResponse = rawResponseString;

            return response;

        }

        #endregion

        #region Search Markets (Quotes)

        public MarketResponse GetPreviousEndOfDateQuote(string ticker)
        {
            TagniFiRequest request = new TagniFiRequest();
            request.ApiKey = ApiKey;

            string statementBaseUrl = "{0}{1}?company={2}";
            request.EndPoint = string.Format(statementBaseUrl, BaseApiUrl, GetEnumDescription(TagnifiQueryType.Markets), ticker);

            RestClient client = new RestClient(request);
            string rawResponseString = client.MakeRequest();

            MarketResponse response = (MarketResponse)JsonConvert.DeserializeObject(rawResponseString, typeof(MarketResponse));

            response.Request = request;
            response.RawResponse = rawResponseString;

            return response;

        }

        #endregion

        #region Company Information

        public CompanyResponse GetCompany(string id)
        {
            TagniFiRequest request = new TagniFiRequest();
            request.ApiKey = ApiKey;

            string statementBaseUrl = "{0}{1}?company={2}";
            request.EndPoint = string.Format(statementBaseUrl, BaseApiUrl, GetEnumDescription(TagnifiQueryType.Companies), id);

            RestClient client = new RestClient(request);
            string rawResponseString = client.MakeRequest();

            CompanyResponse response = (CompanyResponse)JsonConvert.DeserializeObject(rawResponseString, typeof(CompanyResponse));

            response.Request = request;
            response.RawResponse = rawResponseString;

            return response;

        }

        #endregion

        #region Covered Company Information

        public CompanyResponse GetCoveredCompanies(string id)
        {
            TagniFiRequest request = new TagniFiRequest();
            request.ApiKey = ApiKey;

            string statementBaseUrl = "{0}{1}/covered";
            request.EndPoint = string.Format(statementBaseUrl, BaseApiUrl, GetEnumDescription(TagnifiQueryType.Companies));

            RestClient client = new RestClient(request);
            string rawResponseString = client.MakeRequest();

            CompanyResponse response = (CompanyResponse)JsonConvert.DeserializeObject(rawResponseString, typeof(CompanyResponse));

            response.Request = request;
            response.RawResponse = rawResponseString;

            return response;

        }

        #endregion


        #region Private Methods

        private static String GetEnumDescription(Enum e)
        {
            FieldInfo fieldInfo = e.GetType().GetField(e.ToString());

            DescriptionAttribute[] enumAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (enumAttributes.Length > 0)
                return enumAttributes[0].Description;

            return e.ToString();
        }

        #endregion

    }
}
