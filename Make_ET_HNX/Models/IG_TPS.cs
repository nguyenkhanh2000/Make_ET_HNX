using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    public class IG_TPS
    {
        //"f35":"TP","f52"
        public string f35 { get; set; }    //MsgType
        public string f52 { get; set; }    //SendingTime
        public string f55 { get; set; }    //Symbol
        public string f425 { get; set; }    //BoardCode
        public string f555 { get; set; }    //NoTopPrice

        public string f132_1 { get; set; }    //BestBidPrice_1
        public string f1321_1 { get; set; }    //BestBidQtty_1
        public string f133_1 { get; set; }    //BestOfferPrice_1
        public string f1331_1 { get; set; }    //BestOfferQtty_1

        public string f132_2 { get; set; }    //BestBidPrice_2
        public string f1321_2 { get; set; }    //BestBidQtty_2
        public string f133_2 { get; set; }    //BestOfferPrice_2
        public string f1331_2 { get; set; }    //BestOfferQtty_2

        public string f132_3 { get; set; }    //BestBidPrice_3
        public string f1321_3 { get; set; }    //BestBidQtty_3
        public string f133_3 { get; set; }    //BestOfferPrice_3
        public string f1331_3 { get; set; }    //BestOfferQtty_3 
    }
}
