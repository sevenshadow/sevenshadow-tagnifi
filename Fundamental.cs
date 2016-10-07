using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SevenShadow.TagniFi
{
    [DataContract(Name = "fundamental")]
    public class Fundamental
    {
        [DataMember(Name = "filing_type")]
        public string Filing_Type { get; set; }

        [DataMember(Name = "filing_link")]
        public string Filing_Link { get; set; }

        [DataMember(Name = "statement")]
        public string Statement { get; set; }

        [DataMember(Name = "reported_date")]
        public DateTime Reported_Date { get; set; }

        [DataMember(Name = "start_period")]
        public DateTime Start_Period { get; set; }
        
        [DataMember(Name = "end_period")]
        public DateTime End_Period { get; set; }
        
        [DataMember(Name = "fiscal_year")]
        public int Fiscal_Year { get; set; }

        [DataMember(Name = "fiscal_quarter")]
        public int Fiscal_Quarter { get; set; }

        [DataMember(Name = "company")]
        public Company Company { get; set; }

        [DataMember(Name = "tags")]
        public List<FundamentalTag> Tags { get; set; }

        #region Constructors 

        public Fundamental()
        {
            Tags = new List<FundamentalTag>();
        }

        #endregion

    }
}
