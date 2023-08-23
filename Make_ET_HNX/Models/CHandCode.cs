using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    public class CHandCode
    {
        const string __STRING_EQUAL = CConfig.__STRING_EQUAL; //  ;"=";
        const string __STRING_FIX_SEPARATOR = EBasePrice.__STRING_FIX_SEPARATOR;//  "";
        const string __STRING_FIX_TAG_MSG_TYPE = EBasePrice.__TAG_35;

        public ESecurity Fix_Fix2Security(string rawData,int priceDividedBy=1000,int priceRoundDigitsCount = 2) 
        {
            ESecurity eSD = new ESecurity();
            string[] arr = rawData.Split('\x01');
            foreach(string pair in arr)
            {
                if (!string.IsNullOrEmpty(pair))
                {
                    string[] parts = pair.Split('=');
                    switch(parts[0])
                    {
                        case EBase.__TAG_8: eSD.BeginString = parts[1]; break;
                        case EBase.__TAG_9: eSD.BodyLength = Convert.ToInt64(parts[1]); break;
                        case EBase.__TAG_35: eSD.MsgType = parts[1]; break;
                        case EBase.__TAG_49: eSD.SenderCompID = parts[1]; break;
                        case EBase.__TAG_56: eSD.TargetCompID = parts[1]; break;
                        case EBase.__TAG_34: eSD.MsgSeqNum = Convert.ToInt64(parts[1]); break;
                        case EBase.__TAG_52: eSD.SendingTime = parts[1]; break;
                        ////===============================================================================================
                        case EBase.__TAG_55: eSD.Co = parts[1]; break;
                        case EBase.__TAG_260: eSD.Re = parts[1]; break;
                        case EBase.__TAG_332: eSD.Ce = parts[1]; break;
                        case EBase.__TAG_333: eSD.Fl = parts[1]; break;
                        case EBase.__TAG_134: eSD.BQ4 = parts[1]; break;
                        case EBase.__TAG_31: eSD.MP = parts[1]; break;
                        case EBase.__TAG_32: eSD.MQ = parts[1]; break;
                        case EBase.__TAG_x13: eSD.MC = parts[1]; break;
                        case EBase.__TAG_135: eSD.SQ4 = parts[1]; break;
                        case EBase.__TAG_391: eSD.TQ = parts[1]; break;
                        case EBase.__TAG_137: eSD.Op = parts[1]; break;
                        case EBase.__TAG_266: eSD.Hi = parts[1]; break;
                        case EBase.__TAG_2661: eSD.Lo = parts[1]; break;
                        case EBase.__TAG_631: eSD.Av = parts[1]; break;
                        case EBase.__TAG_397: eSD.FB = parts[1]; break;
                        case EBase.__TAG_398: eSD.FS = parts[1]; break;
                        case EBase.__TAG_3301: eSD.FR = parts[1]; break;
                        case EBase.__TAG_x29: eSD.f29 = parts[1]; break;
                        case EBase.__TAG_x30: eSD.f30 = parts[1]; break;
                        case EBase.__TAG_x311: eSD.f31 = parts[1]; break;                   
                    }

                }
            }
            return eSD;
        }
        public double ProcessPrice(string priceString, int priceDividedBy, int priceRoundDigitsCount)
        {
            double price = Convert.ToDouble(priceString); // 43100
            price = price / priceDividedBy; // 43.1
            price = Math.Round(price, priceRoundDigitsCount); // 43.1
            return price;
        }
        public string Get_MsgType(string rawData)
        {
            string msgType = Regex.Match(rawData, "35=(.*?)", RegexOptions.Multiline).Groups[1].Value;
            return msgType;
        }
        //public EPrice Fix_Fix2EPrice(string rawData,bool readAllTags = false, int priceDividedBy = 1000, int priceRoundDigitsCount = 2)
        //{

        //}
        public void SetValues(ref EBasePrice ePrice, EBasePrice.EntryTypes entryType, int rptSeq, string mdUpdateAction, int mdEntryPositionNo, double mdEntryPx, int mdEntrySize, int numberOfOrders, double mdEntryYield, int mdEntryMMSize)
        {
            switch (entryType)
            {
                case EBasePrice.EntryTypes.Bid:
                    switch (mdEntryPositionNo)
                    {
                        case 1: ePrice.BuyPrice1 = mdEntryPx; ePrice.BuyQuantity1 = mdEntrySize; ePrice.BuyPrice1_NOO = numberOfOrders; ePrice.BuyPrice1_MDEY = mdEntryYield; ePrice.BuyPrice1_MDEMMS = mdEntryMMSize; break;
                        case 2: ePrice.BuyPrice2 = mdEntryPx; ePrice.BuyQuantity2 = mdEntrySize; ePrice.BuyPrice2_NOO = numberOfOrders; ePrice.BuyPrice2_MDEY = mdEntryYield; ePrice.BuyPrice2_MDEMMS = mdEntryMMSize; break;
                        case 3: ePrice.BuyPrice3 = mdEntryPx; ePrice.BuyQuantity3 = mdEntrySize; ePrice.BuyPrice3_NOO = numberOfOrders; ePrice.BuyPrice3_MDEY = mdEntryYield; ePrice.BuyPrice3_MDEMMS = mdEntryMMSize; break;
                        case 4: ePrice.BuyPrice4 = mdEntryPx; ePrice.BuyQuantity4 = mdEntrySize; ePrice.BuyPrice4_NOO = numberOfOrders; ePrice.BuyPrice4_MDEY = mdEntryYield; ePrice.BuyPrice4_MDEMMS = mdEntryMMSize; break;
                        case 5: ePrice.BuyPrice5 = mdEntryPx; ePrice.BuyQuantity5 = mdEntrySize; ePrice.BuyPrice5_NOO = numberOfOrders; ePrice.BuyPrice5_MDEY = mdEntryYield; ePrice.BuyPrice5_MDEMMS = mdEntryMMSize; break;
                        case 6: ePrice.BuyPrice6 = mdEntryPx; ePrice.BuyQuantity6 = mdEntrySize; ePrice.BuyPrice6_NOO = numberOfOrders; ePrice.BuyPrice6_MDEY = mdEntryYield; ePrice.BuyPrice6_MDEMMS = mdEntryMMSize; break;
                        case 7: ePrice.BuyPrice7 = mdEntryPx; ePrice.BuyQuantity7 = mdEntrySize; ePrice.BuyPrice7_NOO = numberOfOrders; ePrice.BuyPrice7_MDEY = mdEntryYield; ePrice.BuyPrice7_MDEMMS = mdEntryMMSize; break;
                        case 8: ePrice.BuyPrice8 = mdEntryPx; ePrice.BuyQuantity8 = mdEntrySize; ePrice.BuyPrice8_NOO = numberOfOrders; ePrice.BuyPrice8_MDEY = mdEntryYield; ePrice.BuyPrice8_MDEMMS = mdEntryMMSize; break;
                        case 9: ePrice.BuyPrice9 = mdEntryPx; ePrice.BuyQuantity9 = mdEntrySize; ePrice.BuyPrice9_NOO = numberOfOrders; ePrice.BuyPrice9_MDEY = mdEntryYield; ePrice.BuyPrice9_MDEMMS = mdEntryMMSize; break;
                        case 10: ePrice.BuyPrice10 = mdEntryPx; ePrice.BuyQuantity10 = mdEntrySize; ePrice.BuyPrice10_NOO = numberOfOrders; ePrice.BuyPrice10_MDEY = mdEntryYield; ePrice.BuyPrice10_MDEMMS = mdEntryMMSize; break;
                    }//switch (mdEntryPositionNo)
                    break;
                case EBasePrice.EntryTypes.Offer:
                    switch (mdEntryPositionNo)
                    {
                        case 1: ePrice.SellPrice1 = mdEntryPx; ePrice.SellQuantity1 = mdEntrySize; ePrice.SellPrice1_NOO = numberOfOrders; ePrice.SellPrice1_MDEY = mdEntryYield; ePrice.SellPrice1_MDEMMS = mdEntryMMSize; break;
                        case 2: ePrice.SellPrice2 = mdEntryPx; ePrice.SellQuantity2 = mdEntrySize; ePrice.SellPrice2_NOO = numberOfOrders; ePrice.SellPrice2_MDEY = mdEntryYield; ePrice.SellPrice2_MDEMMS = mdEntryMMSize; break;
                        case 3: ePrice.SellPrice3 = mdEntryPx; ePrice.SellQuantity3 = mdEntrySize; ePrice.SellPrice3_NOO = numberOfOrders; ePrice.SellPrice3_MDEY = mdEntryYield; ePrice.SellPrice3_MDEMMS = mdEntryMMSize; break;
                        case 4: ePrice.SellPrice4 = mdEntryPx; ePrice.SellQuantity4 = mdEntrySize; ePrice.SellPrice4_NOO = numberOfOrders; ePrice.SellPrice4_MDEY = mdEntryYield; ePrice.SellPrice4_MDEMMS = mdEntryMMSize; break;
                        case 5: ePrice.SellPrice5 = mdEntryPx; ePrice.SellQuantity5 = mdEntrySize; ePrice.SellPrice5_NOO = numberOfOrders; ePrice.SellPrice5_MDEY = mdEntryYield; ePrice.SellPrice5_MDEMMS = mdEntryMMSize; break;
                        case 6: ePrice.SellPrice6 = mdEntryPx; ePrice.SellQuantity6 = mdEntrySize; ePrice.SellPrice6_NOO = numberOfOrders; ePrice.SellPrice6_MDEY = mdEntryYield; ePrice.SellPrice6_MDEMMS = mdEntryMMSize; break;
                        case 7: ePrice.SellPrice7 = mdEntryPx; ePrice.SellQuantity7 = mdEntrySize; ePrice.SellPrice7_NOO = numberOfOrders; ePrice.SellPrice7_MDEY = mdEntryYield; ePrice.SellPrice7_MDEMMS = mdEntryMMSize; break;
                        case 8: ePrice.SellPrice8 = mdEntryPx; ePrice.SellQuantity8 = mdEntrySize; ePrice.SellPrice8_NOO = numberOfOrders; ePrice.SellPrice8_MDEY = mdEntryYield; ePrice.SellPrice8_MDEMMS = mdEntryMMSize; break;
                        case 9: ePrice.SellPrice9 = mdEntryPx; ePrice.SellQuantity9 = mdEntrySize; ePrice.SellPrice9_NOO = numberOfOrders; ePrice.SellPrice9_MDEY = mdEntryYield; ePrice.SellPrice9_MDEMMS = mdEntryMMSize; break;
                        case 10: ePrice.SellPrice10 = mdEntryPx; ePrice.SellQuantity10 = mdEntrySize; ePrice.SellPrice10_NOO = numberOfOrders; ePrice.SellPrice10_MDEY = mdEntryYield; ePrice.SellPrice10_MDEMMS = mdEntryMMSize; break;
                    }//switch (mdEntryPositionNo)
                    break;
            } // switch (entryType)

        }
        public string Fix_Fix2Json(string fixString)
        {
            StringBuilder sb = new StringBuilder(fixString);
            if (fixString.Substring(fixString.Length - 1) == __STRING_FIX_SEPARATOR) // ky tu cuoi cung la __STRING_FIX_SEPARATOR thi xoa __STRING_FIX_SEPARATOR
                sb.Length--;
            sb.Replace(__STRING_FIX_SEPARATOR, "\",\"");
            sb.Replace(__STRING_EQUAL, "\":\"");
            sb.Append("\"}");
            sb.Insert(0, "{\"");
            return sb.ToString();
        }
        public EBasePrice Fix_Fix2EBasePrice(string rawData, bool readAllTags = false, int priceDividedBy = 1000, int priceRoundDigitsCount = 2)
        {
            int rptSeq = 0;      // 83		Data sequential number within repeated record
            string mdUpdateAction = null;    // 279		Type code of update action for an entry of market data: 0 = New
            string mdEntryType = null;    // 269		Data classification for an entry of market data: 0 = Bid; 1 = Offer; 2 = Trade; 4 = Opening Price; 5 = Closing Price; 7 = Trading Session High Price; 8 = Trading Session Low Price
            int mdEntryPositionNo = 0;       // 290		Position no (or level) for an entry of market data
            double mdEntryPx = 0;       // 270		Price for an entry of market data
            int mdEntrySize = 0;       // 271		Size (or quantity) for an entry of market data
            int numberOfOrders = 0;       // 346		Number of orders
            double mdEntryYield = 0;       // 30270	Yield of the entry. Bond market only.
            int mdEntryMMSize = 0;       // 30271	Size of the entry provided from market makers
            string sep1 = __STRING_FIX_SEPARATOR + EBasePrice.__TAG_8 + __STRING_EQUAL;// "83="
            string sep2 = EBasePrice.__TAG_8 + __STRING_EQUAL;         // "8="
            string data = rawData.Substring(rawData.IndexOf(sep1));    
            EBasePrice eBP = new EBasePrice(rawData, null);
            string[] bigArray = data.Split(sep1);    // {"1279=0269=1290=1270=0.0271=0346=030271=0", "2279=0269=0290=1270=118500.0271=8346=030271=0", ...}
            StringBuilder sb = new StringBuilder("");            
            
            for(int i = 0; i < bigArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(bigArray[i]))
                {
                    string pair = sep2 + bigArray[i];
                    string[] smallArray = pair.Split(__STRING_FIX_SEPARATOR);
                    for(int j = 0; j < smallArray.Length; j++)
                    {
                        string[] arr = smallArray[j].Split(__STRING_EQUAL);
                        switch (arr[0])
                        {
                            case EBase.__TAG_83: rptSeq = Convert.ToInt32(arr[1]); break;
                            case EBase.__TAG_279: mdUpdateAction = arr[1]; break;
                            case EBase.__TAG_269: mdEntryType = arr[1]; break;
                            case EBase.__TAG_290: mdEntryPositionNo = Convert.ToInt32(arr[1]); break;
                            case EBase.__TAG_270: mdEntryPx = this.ProcessPrice(arr[1], priceDividedBy, priceRoundDigitsCount); break;
                            case EBase.__TAG_271: mdEntrySize = Convert.ToInt32(arr[1]); break;
                            case EBase.__TAG_346: numberOfOrders = Convert.ToInt32(arr[1]); break;
                            case EBase.__TAG_30270: mdEntryYield = Convert.ToDouble(arr[1]); break;
                            case EBase.__TAG_30271: mdEntryMMSize = Convert.ToInt32(arr[1]); break;
                        }
                    }
                    //gan value vao entity
                    int entryType = Convert.ToInt32(mdEntryType);
                    switch(entryType)
                    {
                        case (int)EBasePrice.EntryTypes.Bid: SetValues(ref eBP, EBasePrice.EntryTypes.Bid, rptSeq, mdUpdateAction, mdEntryPositionNo, mdEntryPx, mdEntrySize, numberOfOrders, mdEntryYield, mdEntryMMSize); eBP.Side = "B"; break;
                        case (int)EBasePrice.EntryTypes.Offer: SetValues(ref eBP, EBasePrice.EntryTypes.Offer, rptSeq, mdUpdateAction, mdEntryPositionNo, mdEntryPx, mdEntrySize, numberOfOrders, mdEntryYield, mdEntryMMSize); eBP.Side = "S"; break;
                        case (int)EBasePrice.EntryTypes.Trade: eBP.MatchPrice = mdEntryPx; eBP.MatchQuantity = Convert.ToInt64(mdEntrySize); break;
                        case (int)EBasePrice.EntryTypes.OpenPrice: eBP.OpenPrice = mdEntryPx; eBP.OpenPriceQty = Convert.ToInt64(mdEntrySize); break;
                        case (int)EBasePrice.EntryTypes.ClosePrice: eBP.ClosePrice = mdEntryPx; break;
                        case (int)EBasePrice.EntryTypes.HighPrice: eBP.HighestPrice = mdEntryPx; break;
                        case (int)EBasePrice.EntryTypes.LowPrice: eBP.LowestPrice = mdEntryPx; break;
                    }
                    // repeatingJson 
                    sb.Append(this.Fix_Fix2Json(pair) + CConfig.__STRING_COMMA);
                }
            }

            //bo ky tu cuoi cung
            sb.Length--;
            sb.Insert(0, "{\"data\":[");
            sb.Append("]}");
            // done
            eBP.RepeatingDataJson = sb.ToString();
            eBP.RepeatingDataFix = rawData;
            if (readAllTags)
            {
                string[] arr = rawData.Split(__STRING_FIX_SEPARATOR);
                foreach (string pair in arr)
                {
                    if (!string.IsNullOrEmpty(pair))
                    {
                        string[] parts = pair.Split(__STRING_EQUAL);
                        switch (parts[0])
                        {
                            case EBase.__TAG_8: eBP.BeginString = parts[1]; break;
                            case EBase.__TAG_9: eBP.BodyLength = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_35: eBP.MsgType = parts[1]; break;
                            case EBase.__TAG_49: eBP.SenderCompID = parts[1]; break;
                            case EBase.__TAG_56: eBP.TargetCompID = parts[1]; break;
                            case EBase.__TAG_34: eBP.MsgSeqNum = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_52: eBP.SendingTime = parts[1]; break;
                            //====================================================================================
                            case EBase.__TAG_30001: eBP.MarketID = parts[1]; break;
                            case EBase.__TAG_20004: eBP.BoardID = parts[1]; break;
                            case EBase.__TAG_336: eBP.TradingSessionID = parts[1]; break;
                            case EBase.__TAG_55: eBP.Symbol = parts[1]; break;
                            //case EBase.__TAG_75   : eBP.TradeDate         = parts[1];                   break;
                            //case EBase.__TAG_60   : eBP.TransactTime      = parts[1];                   break;
                            case EBase.__TAG_387: eBP.TotalVolumeTraded = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_381: eBP.GrossTradeAmt = Convert.ToDouble(parts[1]); break;
                            case EBase.__TAG_30521: eBP.SellTotOrderQty = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_30522: eBP.BuyTotOrderQty = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_30523: eBP.SellValidOrderCnt = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_30524: eBP.BuyValidOrderCnt = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_268: eBP.NoMDEntries = Convert.ToInt64(parts[1]); break;
                            case EBase.__TAG_346: eBP.NumberOfOrders = Convert.ToInt64(parts[1]); break;
                            //case EBase.__TAG_381: eBP.GrossTradeAmt = Convert.ToDouble(parts[1]); break;

                            // Repeating Group ............... (xem code o tren)
                            //====================================================================================
                            case EBase.__TAG_10: eBP.CheckSum = parts[1]; break;
                        }
                    }
                }
            }

            return eBP;
        }
        
    }
}
