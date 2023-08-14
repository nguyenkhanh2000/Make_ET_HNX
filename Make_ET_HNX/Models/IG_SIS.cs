using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    public class IG_SIS //StockInfo-Short
    {
        public string f55 { get; set; }     //Symbol
        public string f425 { get; set; }    //BoardCode
        public string f260 { get; set; }    //BasicPrice
        public string f333 { get; set; }    //FloorPrice
        public string f332 { get; set; }    //CeilingPrice
        public string f134 { get; set; }    //TotalBidQtty
        public string f135 { get; set; }    //TotalOfferQtty
        public string f31 { get; set; }     //MatchPrice
        public string f32 { get; set; }     //MatchQtty
        public string f391 { get; set; }    //NM_TotalTradedQtty
        public string f137 { get; set; }    //OpenPrice
        public string f266 { get; set; }    //HighestPrice
        public string f2661 { get; set; }   //LowestPrice
        public string f631 { get; set; }    //MidPx
        public string f397 { get; set; }    //BuyForeignQtty
        public string f398 { get; set; }    //SellForeignQtty
        public string f3301 { get; set; }   //RemainForeignQtty
        public string fx13 { get; set; }    //MatchChange [tutinh]
        public string fx29 { get; set; }    //gia du kien phien ATC [tutinh:PE]
        public string fx30 { get; set; }    //tinh trang : giao dich, niem yet, quyen [tutinh]   
        public string fx311 { get; set; }    //gia khop gan nhat
        public string f399 { get; set; }    //Time
        public string f109 { get; set; }    //TotalListingQtty
        public string f393 { get; set; }    //PT_MatchQtty
        public string f3931 { get; set; }   //PT_MatchPrice
        public string f394 { get; set; }    //PT_TotalTradedQtty
        public string f3941 { get; set; }   //PT_TotalTradedValue
        public string f395 { get; set; }    //TotalBuyTradingQtty
                                            //public string fx31 { get; set; }    //KL du kien phien ATC [tutinh:PE]
#if USE_IG_SI_PT_FL_CE
        public string f3331 { get; set; }    //FloorPricePT
        public string f3321 { get; set; }    //CeilingPricePT
#endif
        public string f336 { get; set; }    //TradingSessionID 
    }
}
