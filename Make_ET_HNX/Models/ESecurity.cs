using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ESecurity : EBase
    {

        /// <summary>
        /// d = Security Definition
        /// </summary>
        public const string __MSG_TYPE =/* __MSG_TYPE_SECURITY_DEFINITION*/__MSG_TYPE_CORE_SI;

        //Co = Symbol
        [JsonProperty(PropertyName = __TAG_55, Order = 8)]
        public string Co { get; set; }
        //Re = BasicPrice
        [JsonProperty(PropertyName = __TAG_260, Order = 9)]
        public string Re { get; set; }
        //Ce = CeilingPrice
        [JsonProperty(PropertyName = __TAG_332, Order = 10)]
        public string Ce { get; set; }
        //Fl = FloorPrice
        [JsonProperty(PropertyName = __TAG_333, Order = 11)]
        public string Fl { get; set; }
        //BQ4 = KL mua 4+ = TotalBidQtty - BQ1 - BQ2 - BQ3 
        [JsonProperty(PropertyName = __TAG_134, Order = 12)]
        public string BQ4 { get; set; }
        //MP = MatchPrice
        [JsonProperty(PropertyName = __TAG_31, Order = 13)]
        public string MP { get; set; }
        //MQ = MatchQtty
        [JsonProperty(PropertyName = __TAG_32, Order = 14)]
        public string MQ { get; set; }
        // MC  = ????? [tu tinh]
        [JsonProperty(PropertyName = __TAG_x13, Order = 15)]
        public string MC { get; set; }
        // SQ4 = TotalOfferQtty = KL ban 4+ = TotalOfferQtty - SQ1 - SQ2 - SQ3 [tu tinh]
        [JsonProperty(PropertyName = __TAG_135, Order = 15)]
        public string SQ4 { get; set; }
        // TQ = NM_TotalTradedQtty
        [JsonProperty(PropertyName = __TAG_391, Order = 16)]
        public string TQ { get; set; }
        // Op = OpenPrice
        [JsonProperty(PropertyName = __TAG_137, Order = 17)]
        public string Op { get; set; }
        // Hi = HighestPice
        [JsonProperty(PropertyName = __TAG_266, Order = 18)]
        public string Hi { get; set; }
        //Lo = LowestPrice
        [JsonProperty(PropertyName = __TAG_2661, Order = 19)]
        public string Lo { get; set; }
        // Av =  MidPx
        [JsonProperty(PropertyName = __TAG_631, Order = 20)]
        public string Av { get; set; }
        // FB =  BuyForeignQtty
        [JsonProperty(PropertyName = __TAG_397, Order = 21)]
        public string FB { get; set; }
        // FS =  SellForeignQtty
        [JsonProperty(PropertyName = __TAG_398, Order = 22)]
        public string FS { get; set; }
        // FR = RemainForeignQtty
        [JsonProperty(PropertyName = __TAG_3301, Order = 23)]
        public string FR { get; set; }
        // gia tam khop trong phien khop lenh dinh ky [29,13.9]
        [JsonProperty(PropertyName = __TAG_x29, Order = 24)]
        public string f29 { get; set; }
        // su kien, quyen => [30,"BE:D"]
        [JsonProperty(PropertyName = __TAG_x30, Order = 25)]
        public string f30 { get; set; }
        // giá khớp gần nhất
        [JsonProperty(PropertyName = __TAG_x311, Order = 26)]
        public string f31 { get; set; }
    }
}
