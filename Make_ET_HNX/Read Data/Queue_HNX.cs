using Make_ET_HNX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Read_Data
{
    public class Queue_HNX
    {
        public string[] arrmessage;
        //public CGlobal.FULL_ROW_QUOTE_ET make_ET; 
        public CGlobal.FULL_ROW_QUOTE_HNX[] make_ET_HNX;
        public IG_SI m_arrsttSI = new IG_SI();
        public IG_TPS[] m_arrsttTP;
        private Dictionary<string, string> m_dic_d_si = new Dictionary<string, string>();
        private Dictionary<string,int> dic_make_ET = new Dictionary<string, int>();
        private Dictionary<string, int> dic_index = new Dictionary<string, int>();
        CHandCode cHandCode = new CHandCode();
        private readonly CConfig config = new CConfig();
        public bool ProcessDataBlock(string messageBlock)
        {
            try
            {
                // moi block chua nhieu msg, moi msg cach nhau 1 dau ENTER xuong dong => split cac msg cho vao array
                using (StreamWriter sw = new StreamWriter("D:\\SourceCode\\Read1.txt", true))
                {

                    sw.WriteLine(messageBlock + Environment.NewLine);

                }
                // ghi log những msg đọc được
                string[] messageArray = messageBlock.Split(CConfig.__STRING_RETURN_NEW_LINE);
                string mess = "";
                //Parallel.ForEach(messageArray, (message) =>
                //{
                //    this.ProcessDataSingle(message);
                //});
                
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
                return false;
            }
        }
        public void ProcessDataSingle(string message)
        {
            try
            {
                if (!string.IsNullOrEmpty(message))
                {
                    string msgType = cHandCode.Get_MsgType(message);
                    int check = 0;
                    switch (msgType)
                    {
                        case ESecurity.__MSG_TYPE:
                            ESecurity e = cHandCode.Fix_Fix2Security(message);
                            if(dic_index.Count == 0)
                            {
                                if (!dic_index.ContainsKey(e.Co))
                                {
                                    dic_index.Add(e.Co, 0);
                                }
                            }
                            else
                            {
                                if (!dic_index.ContainsKey(e.Co))
                                {
                                    dic_index.Add(e.Co, dic_index.Count);  
                                }                     
                            }
                            this.UpdateFullRowQuote(e, null);
                            break;
                        case EBasePrice.__MSG_TYPE:
                            EBasePrice p = cHandCode.Fix_Fix2EBasePrice(message, true, config.PriceDividedBy, config.PriceRoundDigitsCount);
                            if (dic_index.Count == 0)
                            {
                                if (dic_index.ContainsKey(p.Symbol))
                                {
                                    dic_index.Add((p.Symbol), 0);
                                }
                            }
                            else
                            {
                                if (!dic_index.ContainsKey(p.Symbol))
                                {
                                    dic_index.Add(p.Symbol,dic_index.Count);
                                }
                            }
                            this.UpdateFullRowQuote(null, p);
                            break;
                    }
                }
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Queue()
        {
            Queue<byte[]> messageQueue = new Queue<byte[]>();

            // Read the messages from the file and enqueue them as binary            
            foreach (string line in File.ReadLines(CConfig.R_QUEUE_FILE_PATH))
            {
                byte[] namld = Encoding.ASCII.GetBytes(line);
                messageQueue.Enqueue(namld);
            }
            List<string> messageList = new List<string>();
            while (messageQueue.Count > 0)
            {
                byte[] message = messageQueue.Dequeue();
                string messageLine = Encoding.ASCII.GetString(message);
                messageList.Add(messageLine);
                //arrmessage = messageLine.Split('\x01');
                
                //foreach(string msg in arrmessage)
                //{
                //    string[] keyValue = msg.Split('=');
                //    if(keyValue.Length == 2)
                //    {
                //        string key = keyValue[0];
                //        string value = keyValue[1];
                //        this.ProcessMessage(key, value);
                //    }
                //    //this.ProcessMessage(msg);
                //}
            }
            arrmessage = messageList.ToArray();
            foreach (var message in arrmessage)
            {
                this.ProcessDataSingle(message);
            }
        }
        
        public void ProcessMessage(string key, string value)
        {
            string msgType = Check_MSG_Type(key,value);
            if(!string.IsNullOrEmpty(key))
            {
                switch (msgType)
                {
                    case CConfig.TYPE_MSG_SI:
                        if (m_arrsttSI.f55 == null)
                        {
                            if (key == "55") m_arrsttSI.f55 = value;
                            if (key == "260") m_arrsttSI.f260 = value;
                            if(key == "332") m_arrsttSI.f332 = value;
                            if(key == "333") m_arrsttSI.f333 = value;
                            if(key == "134") m_arrsttSI.f134 = value;
                            if(key == "31") m_arrsttSI.f31 = value;
                            if (key == "32") m_arrsttSI.f32 = value;
                            if(key == "x13") m_arrsttSI.fx13 = value;
                            if(key == "135") m_arrsttSI.f135 = value;
                            if (key == "391") m_arrsttSI.f391 = value;
                            if (key == "137") m_arrsttSI.f137 = value;
                            if (key == "266") m_arrsttSI.f266 = value;
                            if (key == "2661") m_arrsttSI.f2661 = value;
                            if (key == "631") m_arrsttSI.f631 = value;
                            if (key == "397") m_arrsttSI.f397 = value;
                            if (key == "398") m_arrsttSI.f398 = value;
                            if (key == "3301") m_arrsttSI.f3301 = value;
                            if (key == "x29") m_arrsttSI.fx29 = value;
                            if (key == "x30") m_arrsttSI.fx30 = value;
                            //if (key == "x311") m_arrsttSI.fx311 = value;
                            
                        }
                        else
                        {

                        }
                        
                        Console.WriteLine("SI");
                        break;
                    case CConfig.TYPE_MSG_TP:
                        Console.WriteLine("TP");
                        break;

                }
            }
        }
        //Check msgtype
        public string Check_MSG_Type(string key, string value)
        {
            if (key == "35" && value =="SI")
            {
                return CConfig.TYPE_MSG_SI;
            }
            else if (key == "35" && value =="TP")
            {
                return CConfig.TYPE_MSG_TP;
            }
            return "";
            //foreach (string arrMessagePart in message)
            //{
            //    if (arrMessagePart == "35=SI")
            //    {
            //        return CConfig.TYPE_MSG_SI;
            //    }
            //    else if (arrMessagePart == "35=TP")
            //    {
            //        return CConfig.TYPE_MSG_TP;
            //    }
            //}

        }
        public void UpdateFullRowQuote(ESecurity d, EBasePrice p)
        {
            try
            {
                if(d != null)
                {
                    if (dic_index.ContainsKey(d.Co))
                    {
                        if(make_ET_HNX == null)
                        {
                            Array.Resize(ref this.make_ET_HNX, dic_index.Count);
                        }
                        if (this.make_ET_HNX != null && dic_index != null)
                        {
                            if(this.make_ET_HNX.Length < dic_index.Count)
                            {
                                Array.Resize(ref this.make_ET_HNX, dic_index.Count);
                            }
                        }
                        int arrayIndex = this.dic_index[d.Co];
                        //make_et_quote
                        make_ET_HNX[arrayIndex].f0 = d.Co.ToString();
                        
                        if(d.Av == null || d.Re == null ||d.Ce == null || d.Fl == null)
                        {

                        }
                        else
                        {
                            make_ET_HNX[arrayIndex].f1 = d.Re.ToString();
                            make_ET_HNX[arrayIndex].f2 = d.Ce.ToString();
                            make_ET_HNX[arrayIndex].f3 = d.Fl.ToString();
                            make_ET_HNX[arrayIndex].f25 = d.Av.ToString();
                        }
                        
                    }
                }
                if(p != null)
                {
                    if (dic_index.ContainsKey(p.Symbol))
                    {
                        if (make_ET_HNX == null)
                        {
                            Array.Resize(ref this.make_ET_HNX, dic_index.Count);
                        }

                        if (this.make_ET_HNX != null && dic_index != null)
                        {
                            if (this.make_ET_HNX.Length < dic_index.Count)
                            {
                                Array.Resize(ref this.make_ET_HNX, dic_index.Count);

                            }
                        }
                        int arrayIndex = this.dic_index[p.Symbol];
                        if (m_dic_d_si.ContainsKey(p.Symbol))
                        {
                            make_ET_HNX[arrayIndex].f0 = m_dic_d_si[p.Symbol];
                        }
                        else
                        {
                            make_ET_HNX[arrayIndex].f0 = p.Symbol;
                        }
                        if (p.HighestPrice != -9999999) //this.make_ET.HighestPice = x.HighestPrice.ToString();
                            make_ET_HNX[arrayIndex].f23 = p.HighestPrice.ToString(); //HighestPice
                        if (p.LowestPrice != -9999999) //this.make_ET.LowestPrice = x.LowestPrice.ToString();
                            make_ET_HNX[arrayIndex].f24 = p.LowestPrice.ToString(); //LowestPrice
                        if (p.OpenPrice != -9999999) //this.make_ET.OpenPrice = x.OpenPrice.ToString();
                            make_ET_HNX[arrayIndex].f22 = p.OpenPrice.ToString(); //OpenPrice
                        if (p.MatchPrice != -9999999) //this.make_ET.MatchPrice = x.MatchPrice.ToString();
                            make_ET_HNX[arrayIndex].f11 = p.MatchPrice.ToString(); //MatchPrice
                        if (p.MatchQuantity != -9999999) //this.make_ET.MatchQtty = x.MatchQuantity.ToString();
                            make_ET_HNX[arrayIndex].f12 = p.MatchQuantity.ToString(); //MatchQtty
                        if (p.TotalVolumeTraded != -9999999) //this.make_ET.NM_TotalTradedQtty = x.TotalVolumeTraded.ToString();
                            make_ET_HNX[arrayIndex].f21 = p.TotalVolumeTraded.ToString(); //NM_TotalTradedQtty

                        if (p.BuyPrice1 != -9999999) //this.make_ET.BestBidPrice1 = x.BuyPrice1.ToString();
                            make_ET_HNX[arrayIndex].f9 = p.BuyPrice1.ToString(); //BestBidPrice1

                        if (p.BuyQuantity1 != -9999999) //this.make_ET.BestBidQtty1 = x.BuyQuantity1.ToString();
                            make_ET_HNX[arrayIndex].f10 = p.BuyQuantity1.ToString(); //BestBidQtty1

                        if (p.BuyPrice2 != -9999999) //this.make_ET.BestBidPrice2 = x.BuyPrice2.ToString();
                            make_ET_HNX[arrayIndex].f7 = p.BuyPrice2.ToString(); //BestBidPrice2

                        if (p.BuyQuantity2 != -9999999)// this.make_ET.BestBidQtty2 = x.BuyQuantity2.ToString();
                            make_ET_HNX[arrayIndex].f8 = p.BuyQuantity2.ToString(); //BestBidQtty2

                        if (p.BuyPrice3 != -9999999)// this.make_ET.BestBidPrice3 = x.BuyPrice3.ToString();
                            make_ET_HNX[arrayIndex].f5 = p.BuyPrice3.ToString(); //BestBidPrice3

                        if (p.BuyQuantity3 != -9999999)// this.make_ET.BestBidQtty3 = x.BuyQuantity3.ToString();
                            make_ET_HNX[arrayIndex].f6 = p.BuyQuantity3.ToString(); //BestBidQtty3
                        //--------------------------------
                        if (p.BuyQuantity4 != -9999999 && p.BuyQuantity5 != -9999999 && p.BuyQuantity6 != -9999999 && p.BuyQuantity7 != -9999999
                            && p.BuyQuantity8 != -9999999 && p.BuyQuantity9 != -9999999 && p.BuyQuantity10 != -9999999) //tổng BestBidQtty4 - BestBidQtty10
                            make_ET_HNX[arrayIndex].f4 = (p.BuyQuantity4 + p.BuyQuantity5 + p.BuyQuantity6 + p.BuyQuantity7
                                + p.BuyQuantity8 + p.BuyQuantity9 + p.BuyQuantity10).ToString();

                        //--------------------------------


                        if (p.SellPrice1 != -9999999)// this.make_ET.BestOfferPrice1 = x.SellPrice1.ToString();
                            make_ET_HNX[arrayIndex].f14 = p.SellPrice1.ToString(); //BestOfferPrice1

                        if (p.SellQuantity1 != -9999999)// this.make_ET.BestOfferQtty1 = x.SellQuantity1.ToString();
                            make_ET_HNX[arrayIndex].f15 = p.SellQuantity1.ToString(); //BestOfferQtty1

                        if (p.SellPrice2 != -9999999) //this.make_ET.BestOfferPrice2 = x.SellPrice2.ToString();
                            make_ET_HNX[arrayIndex].f16 = p.SellPrice2.ToString(); //BestOfferPrice2

                        if (p.SellQuantity2 != -9999999)// this.make_ET.BestOfferQtty2 = x.SellQuantity2.ToString();
                            make_ET_HNX[arrayIndex].f17 = p.SellQuantity2.ToString(); //BestOfferQtty2

                        if (p.SellPrice3 != -9999999) //this.make_ET.BestOfferPrice3 = x.SellPrice3.ToString();
                            make_ET_HNX[arrayIndex].f18 = p.SellPrice3.ToString(); //BestOfferPrice3

                        if (p.SellQuantity3 != -9999999)//this.make_ET.BestOfferQtty3 = x.SellQuantity3.ToString();
                            make_ET_HNX[arrayIndex].f19 = p.SellQuantity3.ToString();

                        if (p.SellQuantity4 != -9999999 && p.SellQuantity4 != -9999999 && p.SellQuantity4 != -9999999 && p.SellQuantity4 != -9999999 && p.SellQuantity4 != -9999999
                           && p.SellQuantity4 != -9999999 && p.SellQuantity4 != -9999999 && p.SellQuantity4 != -9999999)// tổng BestOfferQtty4 - x.SellQuantity10
                            make_ET_HNX[arrayIndex].f20 = (p.SellQuantity4 + p.SellQuantity5 + p.SellQuantity6 + p.SellQuantity7
                                + p.SellQuantity8 + p.SellQuantity9 + p.SellQuantity10).ToString();
                    }
                }
            }catch (Exception e)
            {
                throw e;
            }
        }
        
    }
}
