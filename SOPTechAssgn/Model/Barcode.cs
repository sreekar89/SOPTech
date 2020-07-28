using System;
using Newtonsoft.Json;

namespace SOPTechAssgn.Model
{
    public class BarcodeData
    {
            public string Division { get; set; }
            public string Section { get; set; }
            public string Subsection { get; set; }
            public string Barcode { get; set; }
            public string Location { get; set; }
            [JsonProperty("Qty.in.Stock")]
            public string qtyinstock { get; set; }
            [JsonProperty("Single.Item CP")]
            public int? SingleItemCP { get; set; }
            [JsonProperty("Single.Item MRP")]
            public int? SingleItemMRP { get; set; }
            [JsonProperty("Single.Item EffMRP")]
            public int? SingleItemEffMRP { get; set; }
            [JsonProperty("Vendor City")]
            public string VendorCity { get; set; }
            [JsonProperty("Vendor Name")]
            public string VendorName { get; set; }
            [JsonProperty("Age(Days)")]
            public string AgeDays { get; set; }
            public string CNSNO { get; set; }
            [JsonProperty("Invoice No.")]
            public string InvoiceNo { get; set; }
            [JsonProperty("Inv.LineNo")]
            public string InvLineNo { get; set; }
            public string Promotion { get; set; }
            [JsonProperty("Batch No")]
            public string BatchNo { get; set; }
            [JsonProperty("current MU.%")]
            public string currentMU { get; set; }
            public string DCODE { get; set; }
            [JsonProperty("Desired MU.%")]
            public string DesiredMU { get; set; }
        }
        public class Response
        {
            public int success { get; set; }
            public BarcodeData data { get; set; }
        }
    
}
