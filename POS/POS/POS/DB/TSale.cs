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
    
    public partial class TSale
    {
        public int TSales_id { get; set; }
        public string Sales_Number { get; set; }
        public Nullable<int> Customer { get; set; }
        public Nullable<double> Discount { get; set; }
        public double TotalSales { get; set; }
        public System.DateTime SalesDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int StatusSales { get; set; }
        public int PaymentType { get; set; }
        public Nullable<double> PaymentAmount { get; set; }
        public Nullable<double> Change { get; set; }
        public int created_by { get; set; }
        public System.DateTime created_date { get; set; }
        public Nullable<int> modified_by { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public bool is_deleted { get; set; }
        public Nullable<int> deleted_by { get; set; }
        public Nullable<System.DateTime> deleted_date { get; set; }
        public Nullable<int> PsupplierId { get; set; }
        public string Card_no { get; set; }
        public string Approval_No { get; set; }
    }
}
