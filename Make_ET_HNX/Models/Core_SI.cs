using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Core_SI:EBase
    {
        public const string __MSG_TYPE = __MSG_TYPE_CORE_SI;
        [JsonProperty(PropertyName = __TAG_55,Order = 8)]
        public string MarketID { get;set; }
        [JsonProperty(PropertyName = __TAG_200,Order =9)]
        public string BoardID { get;set; }

    }
}
