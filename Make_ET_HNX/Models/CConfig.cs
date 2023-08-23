using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    public class CConfig
    {
        //chia cac cot gia cho 1000
        public int PriceDividedBy { get; set; }
        //cac cot gia sau khi chia, đc lam tron lay 2 so sau dau phay
        public int PriceRoundDigitsCount { get; set; }
        public const string R_QUEUE_FILE_PATH = "D:\\FPTS Job\\HNX\\02_08_test.txt";
        public const string T_QUEUE_FILE_PATH = "D:\\FPTS Job\\HNX\\queue_HNX.txt";
        public const string MSG_TYPE_STOCK_INFO = "35=SI";
        public const string MSG_TYPE_TOP_N_PRICE = "35=TP";
        public const string TYPE_MSG_SI = "SI";
        public const string TYPE_MSG_TP = "TP";
        public const string __STRING_EQUAL = "=";
        public const string __STRING_COMMA = ",";
        public const string __STRING_RETURN_NEW_LINE = "\r\n";

        public const int __INIT_NULL_INT = -9999999;
        public const long __INIT_NULL_LONG = -9999999;
        public const double __INIT_NULL_DOUBLE = -9999999;
        public const string __INIT_NULL_STRING = null;
        public Dictionary<string, string> m_JSON()
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();                     // dic tuy thuoc vao tung type
                dic.Add("f0", "0");       // Co = Symbol
                dic.Add("f1", "1");      // Re = BasicPrice
                dic.Add("f2", "2");      // Ce = CeilingPrice
                dic.Add("f3", "3");      // Fl = FloorPrice
                dic.Add("f4", "4");      // BQ4 = KL mua 4+ = TotalBidQtty - BQ1 - BQ2 - BQ3 [tu tinh]
                dic.Add("f5", "5");
                dic.Add("f6", "6");
                dic.Add("f7", "7");
                dic.Add("f8", "8");
                dic.Add("f9", "9");
                dic.Add("f10", "10");
                dic.Add("f11", "11");      // MP = MatchPrice
                dic.Add("f12", "12");      // MQ = MatchQtty
                dic.Add("f13", "13");     // MC  = ????? [tu tinh]
                dic.Add("f14", "14");
                dic.Add("f15", "15");
                dic.Add("f16", "16");
                dic.Add("f17", "17");
                dic.Add("f18", "18");
                dic.Add("f19", "19");
                dic.Add("f20", "20");     // SQ4 = TotalOfferQtty = KL ban 4+ = TotalOfferQtty - SQ1 - SQ2 - SQ3 [tu tinh]
                dic.Add("f21", "21");     // TQ = NM_TotalTradedQtty
                dic.Add("f22", "22");     // Op = OpenPrice
                dic.Add("f23", "23");     // Hi = HighestPice
                dic.Add("f24", "24");    // Lo = LowestPrice
                dic.Add("f25", "25");     // Av =  MidPx
                dic.Add("f26", "26");     // FB =  BuyForeignQtty
                dic.Add("f27", "27");     // FS =  SellForeignQtty
                dic.Add("f28", "28");    // FR = RemainForeignQtty
                dic.Add("f29", "29");     // gia tam khop trong phien khop lenh dinh ky [29,13.9]
                dic.Add("f30", "30");     // su kien, quyen => [30,"BE:D"]
                dic.Add("f31", "31");        // giá khớp gần nhất

                return dic;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Dictionary<string, int> m_JSON_Redis()
        {
            try
            {
                Dictionary<string, int> dic = new Dictionary<string, int>();                     // dic tuy thuoc vao tung type
                dic.Add("f0", 1);
                dic.Add("f1", 1000);//1000
                dic.Add("f2", 1000);//1000
                dic.Add("f3", 1000);//1000
                dic.Add("f4", 1);
                dic.Add("f5", 1000);//1000
                dic.Add("f6", 1);
                dic.Add("f7", 1000);//1000
                dic.Add("f8", 1);
                dic.Add("f9", 1000);//1000
                dic.Add("f10", 1);
                dic.Add("f11", 1000);//1000
                dic.Add("f12", 1);
                dic.Add("f13", 1000);// 1000
                dic.Add("f14", 1);
                dic.Add("f15", 1);
                dic.Add("f16", 1000);//1000
                dic.Add("f17", 1);
                dic.Add("f18", 1000);// 1000
                dic.Add("f19", 1);
                dic.Add("f20", 1);
                dic.Add("f21", 1);
                dic.Add("f22", 1000);// 1000
                dic.Add("f23", 1000);//1000
                dic.Add("f24", 1000);//1000
                dic.Add("f25", 1000);//1000
                dic.Add("f26", 1);
                dic.Add("f27", 1);
                dic.Add("f28", 1);
                dic.Add("f29", 1);
                dic.Add("f30", 1);
                dic.Add("f31", 1000);//1000

                return dic;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
       
    }
}
