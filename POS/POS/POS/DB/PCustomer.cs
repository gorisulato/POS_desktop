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
    
    public partial class PCustomer
    {
        public int id_Customer { get; set; }
        public string CustomerName { get; set; }
        public string MemberCode { get; set; }
        public string Alamat { get; set; }
        public string TempatLahir { get; set; }
        public System.DateTime TanggalLahir { get; set; }
        public Nullable<int> PointReward { get; set; }
    }
}
