//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kargo_Takip
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kargo_Durum
    {
        public int Kargo_id { get; set; }
        public string islem { get; set; }
        public string Islem_sube { get; set; }
        public System.DateTime Islem_tarihi { get; set; }
        public int Kargo_durum_id { get; set; }
    
        public virtual Kargo Kargo { get; set; }
    }
}