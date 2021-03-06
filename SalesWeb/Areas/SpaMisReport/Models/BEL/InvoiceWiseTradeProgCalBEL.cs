using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesWeb.Areas.SpaMisReport.Models.BEL
{
    public class InvoiceWiseTradeProgCalBEL
    {

        public string DivisionCode { get; set; }
        public string DivisionName { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string DbLocation { get; set; }
        public string MarketCode { get; set; }
        public string MarketName { get; set; }
        public string RetailerCode { get; set; }
        public string RetailerName { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceDate { get; set; }
        public string ProgramNo { get; set; }
        public string ProgramName { get; set; }
        public string SlabNo { get; set; }        
        public double SlabAmount { get; set; }
        public string DiscPct { get; set; }
        public double SalesValue { get; set; }
        public double ReturnValue { get; set; }
        public double NetIms { get; set; }
        public double ReturnSlabAmount { get; set; }
        public double DiscountValue { get; set; }
        public double ActualDiscunt { get; set; }

        public double GiftItemQty { get; set; }


    }
}