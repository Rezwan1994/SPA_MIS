using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesWeb.Areas.SpaMisReport.Models.BEL
{
    public class SkuNumericSalesAnalysisBEL
    {
       public int SlNo { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionName { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string MarketCode { get; set; }
        public string MarketName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string DbLocation { get; set; }
        public string TotalRetailer { get; set; }
        public string ProductCategoryCode { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string PackSize { get; set; }
        public string NoOfRetailer { get; set; }
        public string AvgOrderQtyPerRet { get; set; }
        public string AvgSalesQtyPerInvoice { get; set; }
        public string AvgSalesQtyPerMonthRet { get; set; }
    }
}