using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.TagniFi
{
    [DataContract(Name = "tag")]
    public class FundamentalTag
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string   Name { get; set; }

        [DataMember(Name = "tag")]
        public string Tag { get; set; }

        [DataMember(Name = "value")]
        public decimal Value { get; set; }

        public List<Transparency> Transparencies { get; set; }

        #region Constructors 

        public FundamentalTag()
        {
            Transparencies = new List<Transparency>();

        }

        #endregion

    }
}
