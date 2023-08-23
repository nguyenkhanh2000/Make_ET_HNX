using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Make_ET_HNX.Models
{
    public class EBasePrice : EBase
    {
        /// <summary>
        /// X = Price
        /// </summary>
        public const string __MSG_TYPE = "TP";

        /// <summary>
        /// <para>size: 1</para>
        /// <para>type: string</para>
        /// </summary>
        public string Side { get; set; }
        /// <summary>
        /// 269	Data classification for an entry of market data: 
        /// 0 = Bid; 1 = Offer; 2 = Trade; 4 = Opening Price; 5 = Closing Price; 7 = Trading Session High Price; 8 = Trading Session Low Price
        /// </summary>
        public enum EntryTypes
        {
            Bid = 0,
            Offer = 1,
            Trade = 2,
            OpenPrice = 4,
            ClosePrice = 5,
            HighPrice = 7,
            LowPrice = 8
        }


        /// <summary>
        /// 2019-12-10 11:58:10 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=30001; required=Y; format=String; length=3</i></para>
        /// <para><b>ID xác định các thị trường</b></para>
        /// <para>
        ///  Sở giao dịch chứng khoán Tp Hồ Chí Minh <br></br>
        /// - STO: Thị trường cổ phiếu<br></br> 
        /// - BDO: Thị trường trái phiếu<br></br> 
        /// - RPO: Thị trường Repo
        /// </para>
        /// <para>
        ///  Sở giao dịch chứng khoán Hà Nội<br></br>
        /// - STX: Thị trường cổ phiếu<br></br> 
        /// - BDX: Thị trường trái phiếu chính phủ<br></br> 
        /// - DVX: Thị trường phái sinh
        /// - UPX: Thị trường UPCOM 
        /// - HCX: Thị trường trái phiếu doanh nghiệp 
        /// </para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_30001, Order = 8)]
        public string MarketID { get; set; }

        /// <summary>
        /// 2019-12-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=20004; required=Y; format=String; length=2</i></para>
        /// <para><b>ID Bảng giao dịch</b></para>
        /// <para>
        /// G1 : Chính(Main)<br></br>
        /// G2 : Trước giờ giao dịch(Pre Open)<br></br>
        /// G3 : Sau giờ giao dịch(Post Close)<br></br>
        /// G4 : Lô lẻ(Odd lot)<br></br>
        /// G7 : Mua bắt buộc(Buy-in)<br></br>
        /// G8 : Bán bắt buộc(Sell-out)<br></br>
        /// T1 : Thỏa thuận(regular)<br></br>
        /// T4 : Thỏa thuận lô lẻ(regular for Odd lot)<br></br>
        /// T2 : Thỏa thuận trước giờ giao dịch(pre)<br></br>
        /// T3 : Thỏa thuận sau giờ giao dịch(post)<br></br>
        /// T5 : Thỏa thuận sau giờ giao dịch cho lô lẻ(post for Odd lot)<br></br>
        /// R1 : Thỏa thuận(Repo)<br></br>
        /// AL : Tất cả Bảng giao dịch<br></br>
        /// </para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_20004, Order = 9)]
        public string BoardID { get; set; }

        /// <summary>
        /// 2020-04-27 15:11:08 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=336 ; required=Y; format=String; length=2</i></para>
        /// <para>
        ///01 = Nạp lại Lệnh GT <br></br>
        ///10 = Phiên mở cửa <br></br>
        ///11 = Phiên mở cửa (mở rộng) <br></br>
        ///20 = Phiên định kỳ sau khi dừng thị trường <br></br>
        ///21 = Phiên định kỳ sau khi dừng thị trường (mở rộng) <br></br>
        ///30 = Kết thúc phiên định kỳ <br></br>
        ///40 = Phiên liên tục <br></br>
        ///50 = Kiểm soát biến động giá <br></br>
        ///51 = Kiểm soát biến động giá (mở rộng) <br></br>
        ///60 = Tiếp nhận giá đóng cửa sau khi đóng cửa <br></br>
        ///80 = Phiên khớp lệnh định kỳ nhiều lần <br></br>
        ///90 = Tạm ngừng giao dịch <br></br>
        ///99 = Đóng cửa thị trường <br></br>
        /// </para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_336, Order = 10)]
        public string TradingSessionID { get; set; }

        /// <summary>
        /// 2020-04-27 15:11:08 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=55 ; required=Y; format=String; length=12</i></para>
        /// <para><b>Mã ISIN , trong trường hợp là sản phẩm REPO thì do Sở định nghĩa. </b></para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_55, Order = 11)]
        public string Symbol { get; set; }

        /// <summary>
        /// 2020-04-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=387 ; required=Y; format=Int; length=12</i></para>
        /// <para><b>Tổng khối lượng giao dịch lũy kế trong ngày</b></para>
        /// </summary
        [JsonProperty(PropertyName = __TAG_387, Order = 14)]
        public long TotalVolumeTraded { get; set; } = CConfig.__INIT_NULL_LONG;

        /// <summary>
        /// 2020-04-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=381 ; required=Y; format=Float; length=23(18.4)</i></para>
        /// <para><b>Tổng giá trị giao dịch lũy kế trong ngày</b></para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_381, Order = 15)]
        public double GrossTradeAmt { get; set; }

        /// <summary>
        /// 2020-04-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=30521 ; required=Y; format=Int; length=12</i></para>
        /// <para><b>Tổng khối lượng của các lệnh bên bán</b></para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_30521, Order = 16)]
        public long SellTotOrderQty { get; set; } = CConfig.__INIT_NULL_LONG;

        /// <summary>
        /// 2020-04-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=30522 ; required=Y; format=Int; length=12</i></para>
        /// <para><b>Tổng khối lượng của các lệnh bên mua</b></para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_30522, Order = 17)]
        public long BuyTotOrderQty { get; set; } = CConfig.__INIT_NULL_LONG;

        /// <summary>
        /// 2020-04-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=30523 ; required=Y; format=Int; length=11</i></para>
        /// <para><b>Số lượng chào giá hợp lệ bên bán</b></para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_30523, Order = 18)]
        public long SellValidOrderCnt { get; set; } = CConfig.__INIT_NULL_LONG;

        /// <summary>
        /// 2020-04-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=30524 ; required=Y; format=Int; length=11</i></para>
        /// <para><b>Số lượng chào giá hợp lệ bên mua</b></para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_30524, Order = 19)]
        public long BuyValidOrderCnt { get; set; } = CConfig.__INIT_NULL_LONG;

        /// <summary>
        /// 2020-04-10 11:58:50 hungtq
        /// <para><i>SPEC version=1.3; date=2019.08.23</i></para>
        /// <para><i>tag=268 ; required=Y; format=Int; length=9</i></para>
        /// <para><b>Số lần lặp dữ liệu được thực hiện ở nội dung bên dưới(Market depth).</b></para>
        /// </summary>
        [JsonProperty(PropertyName = __TAG_268, Order = 20)]
        public long NoMDEntries { get; set; }

        //số lượng lệnh đặt
        [JsonProperty(PropertyName = __TAG_346, Order = 21)]
        public long NumberOfOrders { get; set; }

        // ---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 2021-03-17 16:01:29 ngocta2
        /// <para><b><i>MDEntryPx</i></b></para>
        /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
        /// <para><i>tag=270 ; required=Y; format=Price; length=15(9.4) </i></para>
        /// <para><b>Giá chứng khoán </b></para>
        /// </summary>
        public double BuyPrice1 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        /// <summary>
        /// 2021-03-17 16:01:29 ngocta2
        /// <para><b><i>MDEntrySize</i></b></para>
        /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
        /// <para><i>tag=271 ; required=Y; format=Int; length=12</i></para>
        /// <para><b>Khối lượng</b></para>
        /// </summary>
        public long BuyQuantity1 { get; set; } = CConfig.__INIT_NULL_LONG;
        /// <summary>
        /// 2021-03-17 16:01:29 ngocta2
        /// <para><b><i>NumberOfOrders</i></b></para>
        /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
        /// <para><i>tag=346 ; required=Y; format=Int; length=11</i></para>
        /// <para><b>Số lượng lệnh đặt</b></para>
        /// </summary>
        public int BuyPrice1_NOO { get; set; }
        /// <summary>
        /// 2021-03-17 16:01:29 ngocta2
        /// <para><b><i>MDEntryYield</i></b></para>
        /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
        /// <para><i>tag=30270 ; required=Y; format=Float; length=13(5.6)</i></para>
        /// <para><b>Lợi tức (dành cho trái phiếu)</b></para>
        /// </summary>
        public double BuyPrice1_MDEY { get; set; }
        /// <summary>
        /// 2021-03-17 16:01:29 ngocta2
        /// <para><b><i>MDEntryMMSize</i></b></para>
        /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
        /// <para><i>tag=30271 ; required=Y; format=Int; length=12</i></para>
        /// <para><b>Khối lượng chứng khoán được thực hiện bởi MM</b></para>
        /// </summary>
        public long BuyPrice1_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice1 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity1 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice1_NOO { get; set; }
        public double SellPrice1_MDEY { get; set; }
        public long SellPrice1_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice2 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity2 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice2_NOO { get; set; }
        public double BuyPrice2_MDEY { get; set; }
        public long BuyPrice2_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice2 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity2 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice2_NOO { get; set; }
        public double SellPrice2_MDEY { get; set; }
        public long SellPrice2_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice3 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity3 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice3_NOO { get; set; }
        public double BuyPrice3_MDEY { get; set; }
        public long BuyPrice3_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice3 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity3 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice3_NOO { get; set; }
        public double SellPrice3_MDEY { get; set; }
        public long SellPrice3_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice4 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity4 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice4_NOO { get; set; }
        public double BuyPrice4_MDEY { get; set; }
        public long BuyPrice4_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice4 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity4 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice4_NOO { get; set; }
        public double SellPrice4_MDEY { get; set; }
        public long SellPrice4_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice5 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity5 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice5_NOO { get; set; }
        public double BuyPrice5_MDEY { get; set; }
        public long BuyPrice5_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice5 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity5 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice5_NOO { get; set; }
        public double SellPrice5_MDEY { get; set; }
        public long SellPrice5_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice6 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity6 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice6_NOO { get; set; }
        public double BuyPrice6_MDEY { get; set; }
        public long BuyPrice6_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice6 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity6 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice6_NOO { get; set; }
        public double SellPrice6_MDEY { get; set; }
        public long SellPrice6_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice7 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity7 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice7_NOO { get; set; }
        public double BuyPrice7_MDEY { get; set; }
        public long BuyPrice7_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice7 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity7 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice7_NOO { get; set; }
        public double SellPrice7_MDEY { get; set; }
        public long SellPrice7_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice8 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity8 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice8_NOO { get; set; }
        public double BuyPrice8_MDEY { get; set; }
        public long BuyPrice8_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice8 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity8 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice8_NOO { get; set; }
        public double SellPrice8_MDEY { get; set; }
        public long SellPrice8_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice9 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity9 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice9_NOO { get; set; }
        public double BuyPrice9_MDEY { get; set; }
        public long BuyPrice9_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice9 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity9 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice9_NOO { get; set; }
        public double SellPrice9_MDEY { get; set; }
        public long SellPrice9_MDEMMS { get; set; }
        // ------------------------------------------------------------------------
        public double BuyPrice10 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long BuyQuantity10 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int BuyPrice10_NOO { get; set; }
        public double BuyPrice10_MDEY { get; set; }
        public long BuyPrice10_MDEMMS { get; set; }
        // -------------------------------------
        public double SellPrice10 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long SellQuantity10 { get; set; } = CConfig.__INIT_NULL_LONG;
        public int SellPrice10_NOO { get; set; }
        public double SellPrice10_MDEY { get; set; }
        public long SellPrice10_MDEMMS { get; set; }
        // ------------------------------------------------------------------------

        // ----------------------------------------------------------------------------------------------
        public double MatchPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public long MatchQuantity { get; set; } = CConfig.__INIT_NULL_LONG;
        // ----------------------------------------------------------------------------------------------
        public double OpenPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public double OpenPriceQty { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public double ClosePrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public double HighestPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        public double LowestPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
        // ---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 2020-08-27 09:27:52 ngocta2
        /// field nay tu nghi ra, ko co trong spec MDDS, nen ko co tag		
        /// <para><i>field nay tu nghi ra, ko co trong spec MDDS, nen ko co tag</i></para>
        /// <para><i>yeu cau do dai [varchar](max) hoac 3000 ky tu cua field trong db MSSQL/Oracle</i></para>
        /// <para><b>lay tat ca data tu 8=FIX.4.4 cho den het, gom ca ky tu ko nhin thay dc</b></para>
        /// </summary>
        public string RepeatingDataFix { get; set; }

        /// <summary>
        /// 2020-08-27 09:27:52 ngocta2
        /// field nay tu nghi ra, ko co trong spec MDDS, nen ko co tag		
        /// <para><i>field nay tu nghi ra, ko co trong spec MDDS, nen ko co tag</i></para>
        /// <para><i>yeu cau do dai [varchar](max) hoac 3000 ky tu cua field trong db MSSQL/Oracle</i></para>
        /// <para><b>day la json data (JSON format), co the query theo struct (MSSQL 2016+)</b></para>
        /// <para>{"data":[{"83":"1","270":"aaa"},{"83":"2","270":"bbbbb"}]}</para>
        /// </summary>
        public string RepeatingDataJson { get; set; }


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="copyMe"></param>
        public EBasePrice(string rawData, EBasePrice copyMe) : base(rawData)
        {
            if (copyMe == null) return;

            Type t = copyMe.GetType();

            // System.FieldAccessException : Cannot set a constant field.
            //foreach (FieldInfo fieldInf in t.GetFields()) // {System.Reflection.FieldInfo[1]}     [0]: {System.String __MSG_TYPE}
            //{
            //	fieldInf.SetValue(this, fieldInf.GetValue(copyMe));
            //}


            foreach (PropertyInfo propInf in t.GetProperties()) // {System.Reflection.PropertyInfo[127]}    [0]: {System.String MarketID}; [1]: { System.String BoardID}; [2]: { System.String TradingSessionID}
            {
                propInf.SetValue(this, propInf.GetValue(copyMe));
            }
        }
    }
    //public class EBasePrice:EBase
    //{
    //    public const string __MSG_TYPE = "TP";
    //    public string Side { get;set; }
    //    public enum EntryTypes
    //    {
    //        Bid = 0,
    //        Offer = 1,
    //        Trade = 2,
    //        OpenPrice = 4,
    //        ClosePrice = 5,
    //        HighPrice = 7,
    //        LowPrice = 8
    //    }
    //    //Co = Symbol
    //    [JsonProperty(PropertyName = __TAG_55,Order = 8)]
    //    public string Co { get; set; }
    //    //BestBidPrice_1
    //    [JsonProperty(PropertyName = __TAG_132_1, Order = 9)]
    //    public string BestBidPrice_1 { get; set; }
    //    //BestBidQtty_1
    //    [JsonProperty(PropertyName = __TAG_1321_1, Order = 10)]
    //    public string BestBidQtty_1 { get; set; }
    //    //BestOfferPrice_1
    //    [JsonProperty(PropertyName = __TAG_133_1, Order = 11)]
    //    public string BestOfferPrice_1 { get; set; }
    //    //BestOfferQtty_1
    //    [JsonProperty(PropertyName = __TAG_1331_1, Order = 12)]
    //    public string BestOfferQtty_1 { get; set; }
    //    //BestBidPrice_2
    //    [JsonProperty(PropertyName = __TAG_132_2, Order = 13)]
    //    public string BestBidPrice_2 { get; set; }
    //    //BestBidQtty_2
    //    [JsonProperty(PropertyName = __TAG_1321_2, Order = 14)]
    //    public string BestBidQtty_2 { get; set; }
    //    //BestOfferPrice_2
    //    [JsonProperty(PropertyName = __TAG_133_2, Order = 15)]
    //    public string BestOfferPrice_2 { get; set; }
    //    //BestOfferQtty_2
    //    [JsonProperty(PropertyName = __TAG_1331_2, Order = 16)]
    //    public string BestOfferQtty_2 { get; set; }
    //    //BestBidPrice_3
    //    [JsonProperty(PropertyName = __TAG_132_3, Order = 17)]
    //    public string BestBidPrice_3 { get; set; }
    //    //BestBidQtty_3
    //    [JsonProperty(PropertyName = __TAG_1321_3, Order = 18)]
    //    public string BestBidQtty_3 { get; set; }
    //    //BestOfferPrice_3
    //    [JsonProperty(PropertyName = __TAG_133_3, Order = 19)]
    //    public string BestOfferPrice_3 { get; set; }
    //    //BestOfferQtty_3
    //    [JsonProperty(PropertyName = __TAG_1331_3, Order = 20)]
    //    public string BestOfferQtty_3 { get; set; }
    //    // --------------------------------------------
    //    public double BuyPrice1 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    /// <summary>
    //    /// 2021-03-17 16:01:29 ngocta2
    //    /// <para><b><i>MDEntrySize</i></b></para>
    //    /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
    //    /// <para><i>tag=271 ; required=Y; format=Int; length=12</i></para>
    //    /// <para><b>Khối lượng</b></para>
    //    /// </summary>
    //    public long BuyQuantity1 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    /// <summary>
    //    /// 2021-03-17 16:01:29 ngocta2
    //    /// <para><b><i>NumberOfOrders</i></b></para>
    //    /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
    //    /// <para><i>tag=346 ; required=Y; format=Int; length=11</i></para>
    //    /// <para><b>Số lượng lệnh đặt</b></para>
    //    /// </summary>
    //    public int BuyPrice1_NOO { get; set; }
    //    /// <summary>
    //    /// 2021-03-17 16:01:29 ngocta2
    //    /// <para><b><i>MDEntryYield</i></b></para>
    //    /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
    //    /// <para><i>tag=30270 ; required=Y; format=Float; length=13(5.6)</i></para>
    //    /// <para><b>Lợi tức (dành cho trái phiếu)</b></para>
    //    /// </summary>
    //    public double BuyPrice1_MDEY { get; set; }
    //    /// <summary>
    //    /// 2021-03-17 16:01:29 ngocta2
    //    /// <para><b><i>MDEntryMMSize</i></b></para>
    //    /// <para><i>SPEC version=1.4; date=2020.05.29</i></para>
    //    /// <para><i>tag=30271 ; required=Y; format=Int; length=12</i></para>
    //    /// <para><b>Khối lượng chứng khoán được thực hiện bởi MM</b></para>
    //    /// </summary>
    //    public long BuyPrice1_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice1 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity1 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice1_NOO { get; set; }
    //    public double SellPrice1_MDEY { get; set; }
    //    public long SellPrice1_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice2 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity2 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice2_NOO { get; set; }
    //    public double BuyPrice2_MDEY { get; set; }
    //    public long BuyPrice2_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice2 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity2 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice2_NOO { get; set; }
    //    public double SellPrice2_MDEY { get; set; }
    //    public long SellPrice2_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice3 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity3 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice3_NOO { get; set; }
    //    public double BuyPrice3_MDEY { get; set; }
    //    public long BuyPrice3_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice3 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity3 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice3_NOO { get; set; }
    //    public double SellPrice3_MDEY { get; set; }
    //    public long SellPrice3_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice4 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity4 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice4_NOO { get; set; }
    //    public double BuyPrice4_MDEY { get; set; }
    //    public long BuyPrice4_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice4 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity4 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice4_NOO { get; set; }
    //    public double SellPrice4_MDEY { get; set; }
    //    public long SellPrice4_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice5 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity5 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice5_NOO { get; set; }
    //    public double BuyPrice5_MDEY { get; set; }
    //    public long BuyPrice5_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice5 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity5 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice5_NOO { get; set; }
    //    public double SellPrice5_MDEY { get; set; }
    //    public long SellPrice5_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice6 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity6 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice6_NOO { get; set; }
    //    public double BuyPrice6_MDEY { get; set; }
    //    public long BuyPrice6_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice6 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity6 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice6_NOO { get; set; }
    //    public double SellPrice6_MDEY { get; set; }
    //    public long SellPrice6_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice7 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity7 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice7_NOO { get; set; }
    //    public double BuyPrice7_MDEY { get; set; }
    //    public long BuyPrice7_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice7 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity7 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice7_NOO { get; set; }
    //    public double SellPrice7_MDEY { get; set; }
    //    public long SellPrice7_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice8 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity8 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice8_NOO { get; set; }
    //    public double BuyPrice8_MDEY { get; set; }
    //    public long BuyPrice8_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice8 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity8 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice8_NOO { get; set; }
    //    public double SellPrice8_MDEY { get; set; }
    //    public long SellPrice8_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice9 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity9 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice9_NOO { get; set; }
    //    public double BuyPrice9_MDEY { get; set; }
    //    public long BuyPrice9_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice9 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity9 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice9_NOO { get; set; }
    //    public double SellPrice9_MDEY { get; set; }
    //    public long SellPrice9_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------
    //    public double BuyPrice10 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long BuyQuantity10 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int BuyPrice10_NOO { get; set; }
    //    public double BuyPrice10_MDEY { get; set; }
    //    public long BuyPrice10_MDEMMS { get; set; }
    //    // -------------------------------------
    //    public double SellPrice10 { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long SellQuantity10 { get; set; } = CConfig.__INIT_NULL_LONG;
    //    public int SellPrice10_NOO { get; set; }
    //    public double SellPrice10_MDEY { get; set; }
    //    public long SellPrice10_MDEMMS { get; set; }
    //    // ------------------------------------------------------------------------

    //    // ----------------------------------------------------------------------------------------------
    //    public double MatchPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public long MatchQuantity { get; set; } = CConfig.__INIT_NULL_LONG;
    //    // ----------------------------------------------------------------------------------------------
    //    public double OpenPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public double OpenPriceQty { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public double ClosePrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public double HighestPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;
    //    public double LowestPrice { get; set; } = CConfig.__INIT_NULL_DOUBLE;

    //    //---------------------------------------------------------------------------
    //    public string RepeatingDataJson { get; set; }
    //    public string RepeatingDataFix { get; set; }
    //    public EBasePrice(string rawData, EBasePrice copyMe) : base(rawData)
    //    {
    //        if (copyMe == null) return;

    //        Type t = copyMe.GetType();

    //        // System.FieldAccessException : Cannot set a constant field.
    //        //foreach (FieldInfo fieldInf in t.GetFields()) // {System.Reflection.FieldInfo[1]}     [0]: {System.String __MSG_TYPE}
    //        //{
    //        //	fieldInf.SetValue(this, fieldInf.GetValue(copyMe));
    //        //}


    //        foreach (PropertyInfo propInf in t.GetProperties()) // {System.Reflection.PropertyInfo[127]}    [0]: {System.String MarketID}; [1]: { System.String BoardID}; [2]: { System.String TradingSessionID}
    //        {
    //            propInf.SetValue(this, propInf.GetValue(copyMe));
    //        }
    //    }
    //}
}
