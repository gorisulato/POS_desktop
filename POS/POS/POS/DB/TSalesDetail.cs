//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSalesDetail
    {
        public int Sales_Detail_id { get; set; }
        public int Sales_Number { get; set; }
        public int Items { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> Tax { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public int created_by { get; set; }
        public System.DateTime created_date { get; set; }
        public Nullable<int> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public bool is_deleted { get; set; }
        public Nullable<int> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_date { get; set; }
    }
}
