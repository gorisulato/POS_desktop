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
    
    public partial class PUserImage
    {
        public int Image_id { get; set; }
        public string Filename { get; set; }
        public int user_id { get; set; }
        public byte[] Image { get; set; }
    }
}
